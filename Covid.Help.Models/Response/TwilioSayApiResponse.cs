﻿using System.Xml.Serialization;

namespace Covid.Help.Models.Response
{
    [XmlRoot("Say")]
    public class TwilioSayApiResponse
    {
        [XmlAttribute("voice")]
        public string Voice { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}