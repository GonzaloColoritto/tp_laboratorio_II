using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace Entidades
{
    public enum eTamanio
    {
        Economico,
        Familiar,
        Premium
    }
    public enum eMarca
    {
        Samsung,
        Phillips,
        LG
    }

    [XmlInclude(typeof (Heladera))]
    [XmlInclude(typeof (Lavarropas))]
    [XmlInclude(typeof (Lavavajillas))]

    public abstract class Electrodomestico
    {
        string nombre;
        eMarca marca;
        eTamanio tamanio;

        public Electrodomestico()
        {
            this.Nombre = "";
            this.Tamanio = eTamanio.Economico;
            this.Marca = eMarca.LG;
        }
         
        protected Electrodomestico(string nombre, eTamanio tamanio, eMarca marca):this()
        {
            this.Nombre = nombre;
            this.Tamanio = tamanio;
            this.Marca = marca;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public eTamanio Tamanio { get => tamanio; set => tamanio = value; }
        public eMarca Marca { get => marca; set => marca = value; }

        public abstract override string ToString();
       

    }
}
