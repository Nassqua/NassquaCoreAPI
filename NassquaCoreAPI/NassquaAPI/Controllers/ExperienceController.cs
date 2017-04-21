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
        public List<Models.Experience> Get()
        {
            ExperienceCRUD es = new ExperienceCRUD();
            List<Models.Experience> experiences = es.getExperiences();
            return experiences;
        }
    }
}
