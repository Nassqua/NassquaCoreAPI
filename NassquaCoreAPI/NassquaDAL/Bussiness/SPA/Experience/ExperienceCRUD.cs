using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NassquaDAL.Bussiness.SPA.Experience
{
    public class ExperienceCRUD
    {
        public List<Models.Experience> getExperiences()
        {
            List<Models.Experience> Experiences = new List<Models.Experience>();

            DB_A1EA14_nassquaCoreEntities DB = new DB_A1EA14_nassquaCoreEntities();
            var ExperiencesResults =DB.HZ_ExperienceSet_CRUD("2", "-1", "-1").ToList();
            foreach (var item in ExperiencesResults)
            {
                Experiences.Add(new Models.Experience() { 
                    ExpId = System.Convert.ToInt16(item.ExpId),
                    ExpDesc = item.ExpDesc
                });    
            }

            return Experiences;

        }

    }
}
