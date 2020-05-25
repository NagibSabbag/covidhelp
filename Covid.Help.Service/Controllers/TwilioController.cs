using Covid.Help.Map;
using Covid.Help.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Covid.Help.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioController : Controller
    {
        [HttpPost]
        [Route("call")]
        [ProducesResponseType(typeof(TwilioApiResponse), StatusCodes.Status200OK)]
        public string SetCall()
        {
            var twilioResponse = new TwilioApiResponse
            {
                Say = new TwilioSayApiResponse
                {
                    Voice = "Polly",
                    Language = "pt-BR",
                    Value = "Jair Messias Bolsonaro é um capitão reformado, político e atual presidente do Brasil. Foi deputado federal por sete mandatos entre 1991 e 2018, sendo eleito através de diferentes partidos ao longo de sua carreira. Elegeu-se à presidência pelo Partido Social Liberal."
                }
            };
            var twilioXml = new TwilioApiMap(twilioResponse).ToXml();

            return twilioXml;
        }
    }
}