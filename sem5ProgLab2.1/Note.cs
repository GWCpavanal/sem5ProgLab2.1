using static System.Net.Mime.MediaTypeNames;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace sem5ProgLab2._1
{
    // с сайта https://xmltocsharp.azurewebsites.net/
    [XmlRoot(ElementName = "text")]
    public class Text
    {
        [XmlElement(ElementName = "text")]
        public string text { get; set; }

        [XmlElement(ElementName = "tel")]
        public string Tel { get; set; }

        public override string ToString()
        {
            string res = text + " Tel: " + Tel;
            return res;
        }
    }

    [XmlRoot(ElementName = "note")]
    public class Note
    {
        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }

        [XmlElement(ElementName = "text")]
        public Text text { get; set; }

        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }

        [XmlAttribute(AttributeName = "time")]
        public string Time { get; set; }

        public override string ToString()
        {
            return Subject;
        }
    }
}