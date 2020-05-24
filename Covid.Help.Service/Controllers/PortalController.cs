using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid.Help.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortalController : Controller
    {
        private static List<Person> person;

        [HttpGet]
        [ProducesResponseType(typeof(List<Person>), 200)]
        public async Task<IActionResult> GetAsync()
        {
            if (person == null)
                  person = await Person.GetMock();

            return  Json(person);
        }
        [HttpGet]
        [Route("person/{id}")]
        [ProducesResponseType(typeof(Person), 200)]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            if (person == null)
                person = await Person.GetMock();

            return Json(person.FirstOrDefault(a=> a.Id.ToString() == id));
        }
    }
}
