using NassquaDAL.Bussiness.SPA.Experience;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NassquaTest
{
    class Program
    {
        static void Main(string[] args)
        {

            // NassquaCoreAPI Test

            ExperienceCRUD es = new ExperienceCRUD();

            List<Models.Experience> experiences = es.getExperiences();

            foreach (Models.Experience experience in experiences)
            {
                Console.WriteLine("Experience Id : {0} and Experience Desc: {1}", experience.ExpId, experience.ExpDesc);
            }

            Console.ReadLine();

        }
    }
}
