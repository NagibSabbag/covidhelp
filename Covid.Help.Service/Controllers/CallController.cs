using Covid.Help.Map;
using Covid.Help.Models.Interfaces.Service.Configurations;
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
        private readonly IAppSettings _appSettings;

        public CallController(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }

        [HttpPost]
        [Route("init")]
        [Produces("text/xml")]
        [ProducesResponseType(typeof(CallApiResponse), StatusCodes.Status200OK)]
        public IActionResult InitCall(CallApiRequest callApiRequest)
        {
            var callApiResponse = new CallApiResponse
            {
                Say = new CallSayApiResponse
                {
                    Voice = _appSettings.CallProperties_Voice,
                    Value = _appSettings.CallProperties_Init_Morning + callApiRequest.FromCity
                }
            };
            var callXml = new CallApiMap(callApiResponse).ToXml();

            return this.Content(callXml, "text/xml", Encoding.UTF8);
        }
    }
}