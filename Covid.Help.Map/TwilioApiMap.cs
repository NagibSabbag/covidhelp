using Covid.Help.Models.Response;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Covid.Help.Map
{
    public class TwilioApiMap
    {
        private readonly TwilioApiResponse _twilioApiResponse;

        public TwilioApiMap(TwilioApiResponse twilioApiResponse)
        {
            _twilioApiResponse = twilioApiResponse;
        }

        public string ToXml()
        {
            // removes version
            XmlWriterSettings settings = new XmlWriterSettings
            {
                OmitXmlDeclaration = true,
                Encoding = Encoding.UTF8
            };

            XmlSerializer xsSubmit = new XmlSerializer(typeof(TwilioApiResponse));
            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sw, settings))
                {
                    // removes namespace
                    var xmlns = new XmlSerializerNamespaces();
                    xmlns.Add(string.Empty, string.Empty);

                    xsSubmit.Serialize(writer, _twilioApiResponse, xmlns);
                    return sw.ToString(); // Your XML
                }
            }
        }
    }
}