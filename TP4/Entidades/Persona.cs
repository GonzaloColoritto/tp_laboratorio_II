using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entidades
{
    public enum eGenero
    {
        Masculino,
        Femenino,
        X
    }
    public class Persona
    {
        string nombre;
        int dni;
        int edad;
        eGenero genero;
        bool tienePareja;
        bool tieneHijos; 

        public Persona()
        {
            this.nombre = "";
            this.edad = 0;
            this.genero = eGenero.X;
            this.tieneHijos = false;
            this.tienePareja = false;
        }

        public Persona(string nombre,int dni,int edad, eGenero genero, bool tienePareja, bool tieneHijos): this()
        {
            this.nombre = nombre;
            this.dni = dni;
            this.Edad = edad;
            this.Genero = genero;
            this.TienePareja = tienePareja;
            this.TieneHijos = tieneHijos;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value>=18)
                {
                    this.edad = value;
                }
                else
                {
                    this.edad = 18;
                }
                
            }
        }
        public eGenero Genero
        {
            get
            {
                return this.genero;
            }
            set
            {
                this.genero = value;
            }
        }
        public bool TienePareja
        {
            get
            {
                return this.tienePareja;
            }
            set
            {
                this.tienePareja = value;
            }
        }
        public bool TieneHijos
        {
            get
            {
                return this.tieneHijos;
            }
            set
            {
                this.tieneHijos = value;
            }
        }



        /// <summary>
        /// Sobreescribe el metodo ToString() con la informacion de la persona.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string padre;
            string pareja;

            if (this.TieneHijos)
            {
                padre = "Con hijos";
            }
            else
            {
                padre = "Sin hijos";
            }
            if (this.TienePareja)
            {
                pareja = "En pareja";
            }
            else
            {
                pareja = "Sin pareja";
            }
            sb.Append($"{this.nombre}-{this.Edad} {padre} {pareja}");

            return sb.ToString();

        }

        public static bool operator +(List<Persona> l, Persona p)
        {
              foreach (Persona pAux in l)
              {
                    if (p == pAux)
                    {
                        return false;
                    }
              }
                l.Add(p);
                return true;
        }

        public static bool operator -(List<Persona> l, Persona p)//USAR
        {
            foreach (Persona pAux in l)
            {
                if (p == pAux)
                {
                    l.Remove(pAux);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Comparara los nombres de las personas pasadas por parametro.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Si son iguales retornara true, sino false</returns>
        public static bool operator ==(Persona p1, Persona p2)
        {
            if (p1.Dni == p2.Dni)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Comparara los nombres de las personas pasadas por parametro.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>Retornara lo que devuelva el operador == negado</returns>
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Se le agrega formato a la informacion de la persona para ser mostrada.
        /// </summary>
        /// <returns>Retornara el stringbuilder con la informacion en formato</returns>
        public string Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("{");
            sb.AppendLine($" \"Nombre\" : \"{this.Nombre}\",");
            sb.AppendLine($" \"Dni\" : \"{this.Dni}\",");
            sb.AppendLine($" \"Edad\" : \"{this.Edad}\",");
            sb.AppendLine($" \"Genero\" : \"{this.Genero}\",");
            sb.AppendLine($" \"TienePareja\" : \"{this.tienePareja}\",");
            sb.AppendLine($" \"TieneHijos\" : \"{this.TieneHijos}\"");
            sb.Append("}");

            return sb.ToString();
        }
    }
}
