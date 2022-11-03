using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfCompressor
{
    public static class escribeXml
    {
        static string archivoXml = "config.xml";

        public static void escribe(string tag, string datos)
        {
            System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
            xmlDoc.Load(archivoXml);
            xmlDoc.SelectSingleNode("configuration/" + tag).InnerText = Encrypter.Encriptar(datos);
            xmlDoc.Save(archivoXml);
        }

    }
}
