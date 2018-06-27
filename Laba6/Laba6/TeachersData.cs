using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
    public class TeachersData: DataSuperType
    {
        public List<Teachers> GetAll()
        {
            return this.Context.Teachers.ToList();
        }

        public List<Teachers> FindByTeachersName(Teachers teachers)
        {
            return this.Context.Teachers.Where(p => p.Teachers_name == teachers.Teachers_name).ToList();
        }


        public void AddTeachers(Teachers teachersToAdd)
        {
            this.Context.Teachers.Add(teachersToAdd);
            this.SaveChanges();
        }


        public void RemoveTeachers(Teachers remToTeachers)
        {
            this.Context.Teachers.Remove(remToTeachers);
            this.SaveChanges();
        }

    }
}
