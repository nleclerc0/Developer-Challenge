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
    public class OtherNameAPIController
    {
        TitlesEntities ctx;

        public OtherNameAPIController()
        {
            ctx = new TitlesEntities();
        }

        //[Route("Home")]
        public List<OtherName> GetOtherNames()
        {
            return ctx.OtherNames.ToList();
        }

        //[Route("Home/{value}")]
        public OtherName GetOtherNamesByName(string value)
        {
            OtherName Res = new OtherName();

            //Res = (from c in ctx.OtherNames
            //       where c.TitleId.ToString().Equals(value)
            //       select c);

            return Res;
        }

    }
}