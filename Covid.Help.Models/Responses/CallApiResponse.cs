using System.Xml.Serialization;

namespace Covid.Help.Models.Responses
{
    [XmlRoot("Response")]
    public class CallApiResponse
    {
        public CallSayApiResponse Say { get; set; }
    }
}