using System.Xml.Serialization;

namespace WebAppAspNetMvcExportXml.Models
{
    [XmlRoot("BookImage")]
    public class XmlBookImage
    {
        [XmlElement("Data")]
        public string Data { get; set; }

        [XmlElement("ContentType")]
        public string ContentType { get; set; }
        [XmlElement("FileName")]
        public string FileName { get; set; }
    }
}