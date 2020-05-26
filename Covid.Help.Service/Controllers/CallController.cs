using Covid.Help.Map;
using Covid.Help.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Twilio.AspNet.Common;
using Twilio.AspNet.Core;

namespace Covid.Help.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallController : TwilioController
    {
        [HttpPost]
        [Route("init")]
        [Produces("text/xml")]
        [ProducesResponseType(typeof(CallApiResponse), StatusCodes.Status200OK)]
        public ContentResult InitCall(VoiceRequest voiceRequest)
        {
            var callApiResponse = new CallApiResponse
            {
                Say = new CallSayApiResponse
                {
                    Voice = "Polly.Camila-Neural",
                    Value = voiceRequest.From + " Olá. Olá. Olá. Eu sou a Vivi, sua assistente virtual. Fui desenvolvida para ajudar na triagem dos casos do Corona vírus, assim como passar algumas informações que podem ser de grande ajuda. Espero ajudar de alguma forma."
                }
            };
            var callXml = new CallApiMap(callApiResponse).ToXml();

            return this.Content(callXml, "text/xml", Encoding.UTF8);
        }
    }
}