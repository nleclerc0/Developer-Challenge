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
    public class TitleGenreAPIController
    {
        TitlesEntities ctx;

        public TitleGenreAPIController()
        {
            ctx = new TitlesEntities();
        }

        //[Route("Home")]
        public List<TitleGenre> GetTitleGenres()
        {
            return ctx.TitleGenres.ToList();
        }

        //[Route("Home/{value}")]
        public TitleGenre GetTitleGenresByName(int value)
        {
            TitleGenre Res = new TitleGenre();

            //Res = (from c in ctx.TitleGenres
            //       where c.TitleId == value
            //       select c);

            return Res;
        }

    }
}