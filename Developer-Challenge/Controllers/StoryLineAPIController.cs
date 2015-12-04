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
    public class StoryLineAPIController
    {
        TitlesEntities ctx;

        public StoryLineAPIController()
        {
            ctx = new TitlesEntities();
        }

        //[Route("Home")]
        public List<StoryLine> GetStoryLines()
        {
            return ctx.StoryLines.ToList();
        }

        //[Route("Home/{value}")]
        public StoryLine GetStoryLinesByName(string value)
        {
            StoryLine Res = new StoryLine();

            //Res = (from c in ctx.StoryLines
            //       where c.TitleId.ToString().Equals(value)
            //       select c);

            return Res;
        }

    }
}