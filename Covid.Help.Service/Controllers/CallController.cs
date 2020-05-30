using Covid.Help.Models.Interfaces.Algorithm;
using Covid.Help.Models.Requests;
using Covid.Help.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Covid.Help.Service.Controllers
{
    [Route("api/[controller]")]
    public class CallController : Controller
    {
        private readonly ICall _call;

        public CallController(ICall call)
        {
            _call = call;
        }

        [HttpPost]
        [Route("init")]
        [Produces("text/xml")]
        [ProducesResponseType(typeof(CallApiResponse), StatusCodes.Status200OK)]
        public IActionResult InitCall(CallApiRequest callApiRequest)
        {
            return this.Content(_call.Init(callApiRequest), "text/xml", Encoding.UTF8);
        }
    }
}