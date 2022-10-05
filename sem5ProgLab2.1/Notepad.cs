using static System.Net.Mime.MediaTypeNames;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace sem5ProgLab2._1
{
    [XmlRoot(ElementName = "notepad")]
    public class Notepad // класс со списком Note объектов
    {
        [XmlElement(ElementName = "note")]
        public List<Note> Items { get; set; }
    }
}





