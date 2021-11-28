using System.Xml.Serialization;

namespace WebAppAspNetMvcExportXml.Models
{
    [XmlRoot("Language")]
    public class XmlLanguage
    {
        /// <summary>
        /// Id
        /// </summary> 
        [XmlElement("Id")]
        public int Id { get; set; }
    }
}