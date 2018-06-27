using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
   public class KafedraData:DataSuperType
    {
            public List<Kafedra> GetAll()
            {
                return this.Context.Kafedra.ToList();
            }

            public List<Kafedra> FindByKafedra(Kafedra kafedra)
            {
                return this.Context.Kafedra.Where(p => p.Kafedra_name == kafedra.Kafedra_name).ToList();
            }


            public void AddKafedra(Kafedra kafedraToAdd)
            {
                this.Context.Kafedra.Add(kafedraToAdd);
                this.SaveChanges();
            }


            public void RemoveKafedra(Kafedra remToKafedra)
            {
                this.Context.Kafedra.Remove(remToKafedra);
                this.SaveChanges();
            }

       

    }
}
