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
    public class GenreAPIController
    {
        TitlesEntities ctx;

        public GenreAPIController()
        {
            ctx = new TitlesEntities();
        }

        //[Route("Home")]
        public List<Genre> GetGenres()
        {
            return ctx.Genres.ToList();
        }

        //[Route("Home/{value}")]
        public Genre GetGenresByName(string value)
        {
            Genre Res = new Genre();

            //Res = (from c in ctx.Genres
            //       where c.Id.ToString().Equals(value)
            //       select c);

            return Res;
        }

    }
}