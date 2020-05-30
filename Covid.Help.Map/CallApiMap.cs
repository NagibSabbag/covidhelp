using Covid.Help.Models.Interfaces.Map;
using Covid.Help.Models.Responses;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Covid.Help.Map
{
    public class CallApiMap : ICallApiMap
    {
        public string ConvertToXml(CallApiResponse callApiResponse, string responseBegin, string responseEnd)
        {
            var result = responseBegin;
            callApiResponse.Response.ForEach(x => result += ConvertToXml(x.Say));
            result += responseEnd;

            return result;
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