using Covid.Help.Models.Responses;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Covid.Help.Map
{
    public class CallApiMap
    {
        private readonly CallApiResponse _callApiResponse;

        public CallApiMap(CallApiResponse callApiResponse)
        {
            _callApiResponse = callApiResponse;
        }

        public string ToXml()
        {
            // removes version
            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Encoding = Encoding.UTF8
            };

            XmlSerializer xsSubmit = new XmlSerializer(typeof(CallApiResponse));
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw, settings))
                {
                    // removes namespace
                    var xmlns = new XmlSerializerNamespaces();
                    xmlns.Add(string.Empty, string.Empty);

                    xsSubmit.Serialize(writer, _callApiResponse, xmlns);
                    return sw.ToString();
                }
            }
        }
    }
}