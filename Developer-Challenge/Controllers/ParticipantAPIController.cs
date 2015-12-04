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
    public class ParticipantAPIController
    {
        TitlesEntities ctx;

        public ParticipantAPIController()
        {
            ctx = new TitlesEntities();
        }

        //[Route("Home")]
        public List<Participant> GetParticipants()
        {
            return ctx.Participants.ToList();
        }

        //[Route("Home/{value}")]
        public Participant GetParticipantsByName(string value)
        {
            Participant Res = new Participant();

            //Res = (from c in ctx.Participants
            //       where c.Id.ToString().Equals(value)
            //       select c);

            return Res;
        }

    }
}