﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SpeakingChamber.Model
{
    [XmlType("question")]
    public class Question : BaseModel
    {
        [XmlElement("video")]
        public string Video { get; set; }
        [XmlElement("content")]
        public string Content { get; set; }
        [XmlElement("guide")]
        public string Guide { get; set; }
        [XmlElement("duration")]
        public int Duration { get; set; }
    }
}