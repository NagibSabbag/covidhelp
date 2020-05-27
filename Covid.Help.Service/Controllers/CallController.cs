using Covid.Help.Map;
using Covid.Help.Models.Interfaces.Service.Configurations;
using Covid.Help.Models.Requests;
using Covid.Help.Models.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
                Response = new List<CallUnitApiResponse>
                {
                    new CallUnitApiResponse{ Say = new CallSayApiResponse
                    {
                        Voice = _appSettings.CallEvents.Voice,
                        Value = string.IsNullOrEmpty(callApiRequest.SpeechResult) ? _appSettings.CallEvents.Init.GoodMorning : callApiRequest.SpeechResult
                    }},
                    new CallUnitApiResponse{ Say = new CallSayApiResponse
                    {
                        Voice = _appSettings.CallEvents.Voice,
                        Value = _appSettings.CallEvents.Introduction.Hello
                    }}
                }
            };

            var callXml = new CallApiMap(callApiResponse).ToXml;

            return this.Content(callXml, "text/xml", Encoding.UTF8);
        }
    }
}