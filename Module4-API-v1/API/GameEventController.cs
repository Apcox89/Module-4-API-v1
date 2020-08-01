using Module4_API_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Module4_API_v1.API
{
    public class GameEventController : ApiController
    {
        // GET: api/GameEvent
        public GameEvent Get()
        {
            List<Game> _scenelist = new List<Game>();
            //this would almost always come from a data source:
            _scenelist.Add(new Game("Read", "Learn info about your environment."));
            _scenelist.Add(new Game("Train", "Practice skills to earn xp."));
            _scenelist.Add(new Game("Hack", "Practice programming puzzles to enhance portal-conjuring ability. "));
            GameEvent _scene = new GameEvent(_scenelist.ToArray());
            return _scene;
            //result api returns all data values for both Game and Player classes
            //inheritance working with the api, now how to constrain?
        } 

        // GET: api/GameEvent/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/GameEvent
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GameEvent/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GameEvent/5
        public void Delete(int id)
        {
        }
    }
}
