using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DB
    {
        private string connectionStr;

        public DB(string connection)
        {
            this.connectionStr = connection;
        }


        public List<Persona> RetornarPersonas()
        {
            List<Persona> listaAux = new List<Persona>();
            string consulta = "select * from Personas";

            SqlConnection cn = new SqlConnection(this.connectionStr);
            SqlCommand comand = new SqlCommand(consulta, cn);

            try
            {
                cn.Open();
                SqlDataReader reader = comand.ExecuteReader();//esta linea no funciona

                while (reader.Read())
                {
                    Persona p = new Persona((string)reader["Nombre"],(int) reader["Dni"],
                        (int)reader["Edad"], (eGenero)reader["Genero"],(bool)reader["Tiene_Pareja"], (bool)reader["Tiene_Hijos"]);

                    //LocalParaLaCasa.Personas.Add(p);
                     
                    listaAux.Add(p);
                }

                return listaAux;
            }
            finally
            {
                cn.Close();
            }

        }


    }
}
