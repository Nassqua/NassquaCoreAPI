using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NassquaAPI.Controllers
{
    public class AddController : ApiController
    {
        public Models.AddResult Get(float num1,float num2)
        {
            return new Models.AddResult() { result = num1 + num2 };
        }

    }
}
