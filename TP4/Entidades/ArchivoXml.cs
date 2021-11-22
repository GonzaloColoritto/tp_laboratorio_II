using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{

    public class ArchivoXml : IArchivador<List<Premio>,List<Electrodomestico>>
    {
        private readonly string path;

        public ArchivoXml() 
        { 

        }

        public ArchivoXml(string path)
        {
            this.path = path;
        }

      

        /// <summary>
        /// Guardara la lista pasada por parametro en un archivo xml
        /// </summary>
        /// <param name="lista"></param>
        public void Guardar(List<Premio> lista)
        {
            using (XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
            {
                XmlSerializer escritor = new XmlSerializer(typeof(List<Premio>));
                escritor.Serialize(writer, lista);
            }
        }
        /// <summary>
        /// Guardara la lista pasada por parametro en un archivo xml
        /// </summary>
        /// <param name="lista"></param>
        public void Guardar(List<Electrodomestico> lista)
        {
            using (XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
            {
                XmlSerializer escritor = new XmlSerializer(typeof(List<Electrodomestico>));
                escritor.Serialize(writer, lista);
            }
        }

        /// <summary>
        /// Guardara la lista pasada por parametro en un archivo xml en la ruta pasada por parametro
        /// </summary>
        /// <param name="lista"></param>
        public void Guardar(List<Electrodomestico> lista,string ruta)
        {
            using (XmlTextWriter writer = new XmlTextWriter(ruta, System.Text.Encoding.UTF8))
            {
                XmlSerializer escritor = new XmlSerializer(typeof(List<Electrodomestico>));
                escritor.Serialize(writer, lista);
            }
        }

        /// <summary>
        /// Leera el archivo xml en la ruta del archivo
        /// </summary>
        /// <returns>Retornara la lista leida</returns>
        public List<Premio> LeerPremios()
        {
            if (File.Exists(this.path))
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Premio>));

                    
                    return (List<Premio>)serializer.Deserialize(xmlTextReader);
                }
            }
            else
            {
                Exception ex = new Exception("No existe el archivo seleccionado.");
                throw ex;
            }
        }

        /// <summary>
        /// Leera el archivo xml en la ruta del archivo
        /// </summary>
        /// <returns>Retornara la lista leida</returns>
        public List<Electrodomestico> LeerElectrodomesticos()
        {
            if (File.Exists(this.path))
            {
                using (XmlTextReader xmlTextReader = new XmlTextReader(path))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Electrodomestico>));

                    
                    return (List<Electrodomestico>)serializer.Deserialize(xmlTextReader);
                }
            }
            else
            {
                Exception ex = new Exception("No existe el archivo seleccionado.");
                throw ex;
            }


        }

    }
}
