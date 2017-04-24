using NassquaDAL;
using NassquaDAL.Bussiness.SPA.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NassquaAPI.Controllers
{
    public class ExperienceController : ApiController
    {
        public List<Experience> Get()
        {            
            ExperienceProcedures ExpProcedures = new ExperienceProcedures();
            return ExpProcedures.getExperiences();   
        }
    }
}
