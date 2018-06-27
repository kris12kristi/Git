using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public class DataSuperType
    {

        private ClassLibrary context = null;
        public ClassLibrary Context
        {
            get
            {
                return this.context = context ?? new ClassLibrary("AplicationContext");
            }
            set
            {
                this.context = value;
            }
        }

        public void SaveChanges()
        {
            try
            {
                this.Context.SaveChanges();
                this.Context = null;
            }
            catch (Exception ex)
            {
                FileInfo fi = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "Log.txt");
                StreamWriter sr = new StreamWriter(fi.OpenWrite());
                foreach (var validationError in this.Context.GetValidationErrors())
                {
                    StringBuilder errorString = new StringBuilder();
                    errorString.AppendLine("====//=//====");
                    foreach (var error in validationError.ValidationErrors)
                    {
                        errorString.AppendLine(string.Format("{0} - {1}", error.PropertyName, error.ErrorMessage));
                    }

                    sr.WriteLine(errorString.ToString());
                }

                sr.Close();
                this.Context = null;
            }
        }

    }

}
