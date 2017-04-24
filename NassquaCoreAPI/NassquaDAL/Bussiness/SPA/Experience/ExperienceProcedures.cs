using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NassquaDAL.Bussiness.SPA.Experience
{
    public class ExperienceProcedures
    {
        public List<NassquaDAL.Experience> getExperiences()
        {          
            EFNassquaDB EFNassquaDBObj = new EFNassquaDB();
            return EFNassquaDBObj.HZ_Experience_CRUD("2", "-1", "-1").ToList();                           
        }

    }
}
