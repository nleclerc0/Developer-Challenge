using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Developer_Challenge.Models;
using System.Web.Routing;

namespace Developer_Challenge.Controllers
{
    public class AwardAPIController
    {
        TitlesEntities ctx;

        public AwardAPIController()
        {
            ctx = new TitlesEntities(); 
        }
 
        //[Route("Home")]
        public List<Award> GetAwards()
        {
            return ctx.Awards.ToList();
        }
 
        //[Route("Home/{value}")]
        public Award GetAwardsByName(string value)
        {
            Award Res = new Award();

            //Res = (from c in ctx.Awards
            //       where c.TitleId.ToString().Equals(value)
            //       select c);
                    
            return Res;
        }

    }
}