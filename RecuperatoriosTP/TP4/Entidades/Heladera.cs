using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Heladera : Electrodomestico
    {
        int temperaturaMedia;
        bool tieneFreezer;
        
        public Heladera()
        {
            this.temperaturaMedia = 0;
            this.tieneFreezer = true;
        }

       
        public Heladera(int temperaturaMedia, bool tieneFreezer,string nombre, eTamanio tamanio, eMarca marca):base(nombre,tamanio,marca)
        {
            this.temperaturaMedia = temperaturaMedia;
            this.tieneFreezer = tieneFreezer;
        }

        public int TemperaturaMedia { get => temperaturaMedia; set => temperaturaMedia = value; }
        public bool TieneFreezer { get => tieneFreezer; set => tieneFreezer = value; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"'{this.Nombre}' {this.Tamanio} {this.Marca} Freezer:{this.tieneFreezer} Temp media:{this.temperaturaMedia}");
            sb.Append("");
            return sb.ToString();
        }

        
    }
}
