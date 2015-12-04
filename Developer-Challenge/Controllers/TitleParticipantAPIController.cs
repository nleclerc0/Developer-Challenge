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
    public class TitleParticipantAPIController
    {
        TitlesEntities ctx;

        public TitleParticipantAPIController()
        {
            ctx = new TitlesEntities();
        }

        //[Route("Home")]
        public List<TitleParticipant> GetTitleParticipants()
        {
            return ctx.TitleParticipants.ToList();
        }

        //[Route("Home/{value}")]
        public TitleParticipant GetTitleParticipantsByName(string value)
        {
            TitleParticipant Res = new TitleParticipant();

            //Res = (from c in ctx.TitleParticipants
            //       where c.TitleId.ToString().Equals(value)
            //       select c);

            return Res;
        }

    }
}