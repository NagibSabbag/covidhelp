using System.Xml.Serialization;

namespace Covid.Help.Models.Response
{
    [XmlRoot("Response")]
    public class CallApiResponse
    {
        public CallSayApiResponse Say { get; set; }
    }
}