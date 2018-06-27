using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6
{
   public class SubjectsData: DataSuperType
    {
            public List<Subjects> GetAll()
            {
                return this.Context.Subjects.ToList();
            }

            public List<Subjects> FindBySubjectName(Subjects subj)
            {
                return this.Context.Subjects.Where(p => p.Subject_name == subj.Subject_name).ToList();
            }

            public void AddSubject(Subjects subjToAdd)
            {
                this.Context.Subjects.Add(subjToAdd);
                this.SaveChanges();
            }

            public void RemoveSubject(Subjects subjToTeam)
            {
                this.Context.Subjects.Remove(subjToTeam);
                this.SaveChanges();
            }


    }
}
