using System.Xml.Serialization;

namespace Covid.Help.Models.Response
{
    [XmlRoot("Response")]
    public class TwilioApiResponse
    {
        public TwilioSayApiResponse Say { get; set; }
    }
}