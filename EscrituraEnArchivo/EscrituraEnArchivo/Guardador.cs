using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraEnArchivo
{
    public static class Guardador
    {
        
        public static bool GuardarPersona(Persona persona)
        {
            bool bandera = true;
            StreamWriter obj = null; //Le asigno null para que en el finally no me salte error

            try
            {
                obj = new StreamWriter("Personas.txt");
                obj.WriteLine(persona.ToString());
                

                bandera = true;
            }
            catch (Exception)
            {

                bandera = false;
            }
            finally
            {
                obj.Close();
            }

            return bandera;
        }

       

        public static Persona LeerUnaPersona()
        {
            Persona unaPersona = null;
            Persona nuevaPersona = null;
            StreamReader obj = null;
            string[] array;

            try
            {
                unaPersona = new Persona("Diego", "4567");
                obj = new StreamReader("Personas.txt");

                string linea = obj.ReadLine();
                array = linea.Split(',');
                nuevaPersona = new Persona(array[0], array[1]);
                

            }
            catch (Exception)
            {
                
                throw;
            }
            
            return nuevaPersona;
        }


        public static List<Persona> RetornarListado()
        {

            List<Persona> miListado;

            try
            {
                miListado = new List<Persona>();

                using (StreamReader lector = new StreamReader("Personas.txt"))
                {
                    string renglon;
                    string[] array;

                    while ((renglon = lector.ReadLine()) != null)
                    {
                        array = renglon.Split(',');

                        miListado.Add(new Persona(array[0], array[1]));
                    }

                }

            }
            catch (Exception)
            {
                
                throw;
            }

            return miListado;

        }

    }


}
