using Covid.Help.Models.Responses;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Covid.Help.Map
{
    public class CallApiMap
    {
        public string ToXml { get; private set; }

        public CallApiMap(CallApiResponse callApiResponse, string responseBegin, string responseEnd)
        {
            ToXml = responseBegin;
            callApiResponse.Response.ForEach(x => ToXml += ConvertToXml(x));
            ToXml += responseEnd;
        }

        private string ConvertToXml(CallUnitApiResponse callUnitApiResponse)
        {
            return ConvertToXml(callUnitApiResponse.Say);
        }

        private string ConvertToXml(CallSayApiResponse callSayApiResponse)
        {
            // removes version
            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Encoding = Encoding.UTF8
            };

            XmlSerializer xsSubmit = new XmlSerializer(typeof(CallSayApiResponse));
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw, settings))
                {
                    // removes namespace
                    var xmlns = new XmlSerializerNamespaces();
                    xmlns.Add(string.Empty, string.Empty);

                    xsSubmit.Serialize(writer, callSayApiResponse, xmlns);
                    return sw.ToString();
                }
            }
        }
    }
}