using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Entidades
{
    public class ArchivoJSON<T>
    {

        static string path;

        static  ArchivoJSON()
        {
            path = Environment.CurrentDirectory;
        }
        
        
        public static void Guardar(T lista,string nombre)
        {
            string archivoNombre = path + nombre;
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                File.WriteAllText(archivoNombre, JsonSerializer.Serialize(lista));
            }
            catch(Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }

        }

        public static T Leer(string nombre)
        {
            

            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;

            try
            {
                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }


                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo ubicado en {path}", e);
            }
        }
    }
}
