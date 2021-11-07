using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Premio
    {
        Electrodomestico electrodomestico;
        Persona persona;

        public Premio()
        {
            this.Electrodomestico = null;
            this.Persona = null;
        }

        public Premio(Electrodomestico electrodomestico, Persona persona):this()
        {
            this.electrodomestico = electrodomestico;
            this.persona = persona;
        }

        public Electrodomestico Electrodomestico 
        {
            get { return this.electrodomestico; }
            set
            {
                this.electrodomestico = value;
            }
        }
        public Persona Persona
        {
            get { return this.persona; }
            set
            {
                this.persona = value;
            }
        }

        public static bool operator +(List<Premio> l, Premio p)
        {
            if (l != null && p!= null)
            {

                l.Add(p);
                return true;


            }
            else
            {
                return false;
            }
            
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if(this.Electrodomestico is Heladera)
            {
                sb.Append($"Ganador: {this.Persona.Nombre} - Premio elegido: Heladera {this.Electrodomestico.Nombre}-{this.Electrodomestico.Marca}");
            }
            if (this.Electrodomestico is Lavarropas)
            {
                sb.Append($"Ganador: {this.Persona.Nombre} - Premio elegido: Lavarropas {this.Electrodomestico.Nombre}-{this.Electrodomestico.Marca}");
            }
            if (this.Electrodomestico is Lavavajillas)
            {
                sb.Append($"Ganador: {this.Persona.Nombre} - Premio elegido: Lavavajillas {this.Electrodomestico.Nombre}-{this.Electrodomestico.Marca}");
            }

            return sb.ToString();
        }

    }
}
