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
    public class TitleAPIController : ApiController
    {
        TitlesEntities ctx;

        public TitleAPIController()
        {
            ctx = new TitlesEntities(); 
        }
 
        //[Route("Home")]
        public List<Title> GetTitles()
        {
            return ctx.Titles.ToList();
        }
 
        //[Route("Home/{value}")]
        public List<Title> GetTitlesByName(string value)
        {
            List<Title> Res = new List<Title>(); 
            
                    Res = (from c in ctx.Titles
                           where c.TitleName.Contains(value)
                              select c).ToList();
                    
            return Res;
        }

    }
}