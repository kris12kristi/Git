using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public class InstytytsData : DataSuperType
    {
        public List<Instytyts> GetAll()
        {
            return this.Context.Instytyts.ToList();
        }

        public List<Instytyts> FindByCName(Instytyts inst)
        {
            return this.Context.Instytyts.Where(p => p.Instytyts_name == inst.Instytyts_name).ToList();
        }


        public void AddInstytyts(Instytyts instToAdd)
        {
            this.Context.Instytyts.Add(instToAdd);
            this.SaveChanges();
        }


        public void RemoveInstytyts(Instytyts remToInstytyts)
        {
            this.Context.Instytyts.Remove(remToInstytyts);
            this.SaveChanges();
        }
    }


}
