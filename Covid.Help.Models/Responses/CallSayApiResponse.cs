using System.Xml.Serialization;

namespace Covid.Help.Models.Responses
{
    [XmlRoot("Say")]
    public sealed class CallSayApiResponse
    {
        [XmlAttribute("voice")]
        public string Voice { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}