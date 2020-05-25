using Covid.Help.Map;
using Covid.Help.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Covid.Help.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioController : Controller
    {
        [HttpPost]
        [Route("call")]
        [Produces("text/xml")]
        [ProducesResponseType(typeof(TwilioApiResponse), StatusCodes.Status200OK)]
        public ContentResult SetCall()
        {
            //var parameters = string.Empty;
            //using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            //    parameters = await reader.ReadToEndAsync();

            var twilioResponse = new TwilioApiResponse
            {
                Say = new TwilioSayApiResponse
                {
                    Voice = "Polly.Camila-Neural",
                    Value = "Olá. Eu sou a Viviam, sua assistente virtual. Fui desenvolvida para ajudar na triagem dos casos do Corona vírus, assim como passar algumas informações que podem ser de grande ajuda. Espero ajudar de alguma forma."
                }
            };
            var twilioXml = new TwilioApiMap(twilioResponse).ToXml();

            return this.Content(twilioXml, "text/xml", Encoding.UTF8);
        }
    }
}