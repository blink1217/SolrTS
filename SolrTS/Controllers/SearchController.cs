using Microsoft.AspNetCore.Mvc;
using SolrTS.Database;
using SolrTS.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SolrTS.Controllers
{
    public class SearchController : Controller
    {
        private readonly SolrContext _solrContext;
        public SearchController(SolrContext solrContext)
        {
            _solrContext = solrContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Route("lookup/{Query}")]
        public IActionResult Lookup(string Query)
        {
            //In reality I would use Solr for search queries 
            //but since I'm not going through the trouble of setting one up and writing all the code you will have to imagine it
            //https://solr-express.gitbook.io/docs/tutorials/getting-started

            //This is not a good way to search!!
            var person = _solrContext.Persons.Where(e => e.Name.Contains(Query)).FirstOrDefault();
            return Json(person);
        }

        [Route("add/{Name}")]
        public async Task<IActionResult> Add(string Name)
        {
            var id = _solrContext.Persons.Count() + 1;

            var newPerson = new Person
            {
                Id = "PX" + id,
                Name = Name,
                Group = "Red",
                JoinDate = DateTime.Now
            };

            _solrContext.Persons.Add(newPerson);
            await _solrContext.SaveChangesAsync();

            return Json(newPerson);
        }
    }
}
