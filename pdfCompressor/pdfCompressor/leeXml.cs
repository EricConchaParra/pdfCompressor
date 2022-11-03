using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace pdfCompressor
{
    public static class leeXml
    {

        public static string lee(string tag)
        {
            string archivoXml = "config.xml";
            string lectura = "";

            //===============Cargo el XML========================
            try
            {
                string xmlString = System.IO.File.ReadAllText(archivoXml);
                StringBuilder output = new StringBuilder();

               

                // Create an XmlReader
                using (XmlReader reader = XmlReader.Create(new StringReader(xmlString)))
                {
                    reader.ReadToFollowing(tag);
                    lectura = reader.ReadElementContentAsString();
                    lectura = Encrypter.DesEncriptar(lectura);
                    return lectura;
                }


            }
            catch (Exception)
            {
                lectura = "Error";
                return lectura;
            }
            
            
        }

        public static bool verifica(string dato)
        {
            bool verifica = false;

            if (dato != "Error")
            {
                return verifica = true;
            }

            return verifica;
        }
    }
}
