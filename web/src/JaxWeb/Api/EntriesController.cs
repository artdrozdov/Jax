using System.Collections.Generic;
using JaxWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace JaxWeb.Api {

    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EntriesController: Controller {

        public IEnumerable<Entry> Get(){
            var result = new List<Entry>();
            result.Add(new Entry{
                Href = "http://google.com",
                Title = "Google",
                Description = "Yo!"
            });
            result.Add(new Entry{
                Href="http://bing.com",
                Title = "Bing",
                Description = "gj"
            });
            return result;
        }

    }

}