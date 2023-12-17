using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases_biblio
{
    public static class Serializar
    {
        public static void Escribir(List<Libros> catalogo, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Libros>));
                    serializer.Serialize(sw, catalogo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }

        }

        public static List<Libros> Leer(string path) // creo una funcion estatica que recibira un path y devolvera una lista.

        {
            List<Libros> list = new List<Libros>();

            try
            {
                using (StreamReader sr = new StreamReader(path)) //crea la instancia de un objeto stream reader  que leer un archivo
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Libros>)); //crea una instancia del objeto XML Serializer que convierte objetos en formatos XML, typeofe es un operador que
                    //devuelve un objeto type que representa los datos de la lista, osea recibira un tipo de lista de scursales.
                    list = serializer.Deserialize(sr) as List<Libros>;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); //lanza la exepcion por fuera de esta clase, es decir cuando el metodo escribir se ejecute dentro del codigo de los formularios.


            }
            return list;


        }
    }
}