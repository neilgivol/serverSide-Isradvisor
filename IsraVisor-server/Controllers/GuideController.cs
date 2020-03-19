﻿using IsraVisor_server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IsraVisor_server.Controllers
{
    public class GuideController : ApiController
    {
        // GET api/<controller>
        public List<Guide> Get()
        {
            Guide g = new Guide();
            return g.ReadGuides();
        }

        // GET api/<controller>/5
        public List<Guide_Language> Get(int id)
        {
            Guide_Language g = new Guide_Language();
            return g.ReadAllGuideLanguages(id);
        }

        // POST api/<controller>
        public void Post([FromBody]Guide g)
        {
            Guide g1 = new Guide();
            g1.PostGuideToSQL(g);
        }

        [HttpPost]
        [Route("api/Guide/PostGuideLanguage")]
        public List<Guide_Language> PostLanguage([FromBody]List<Guide_Language> guideLan)
        {
            Guide_Language guideLnaguage = new Guide_Language();
            return guideLnaguage.PostGuideLanguagesToSQL(guideLan);
            //guideLnagu.PostLanguagesGuideToSQL(guideLan);
        }

        // PUT api/<controller>/5
        public int Put([FromBody]Guide g)
        {
            Guide guide = new Guide();
            return(guide.UpdateGuideSQL(g));
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}