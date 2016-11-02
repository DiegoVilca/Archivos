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
        
        public static bool GuardarPersona(Persona persona)  //Escribo en el archivo
        {
            bool bandera = true;
            StreamWriter escritor = null; //Le asigno null para que en el finally no me salte error "unassigned"

            try
            {
                escritor = new StreamWriter("Personas.txt", true);  //si paso por parametro true agrego datos a los ya existentes
                escritor.WriteLine(persona.ToString());              //si agrego false los sobreescribo
                

                bandera = true;
            }
            catch (Exception)
            {

                bandera = false;
            }
            finally
            {
                escritor.Close();
            }

            return bandera;
        }

       

        public static Persona LeerUnaPersona() //Leo un archivo
        {
            
            Persona nuevaPersona = null;
            StreamReader lector = null;
            string[] arrayString;

            try
            {
                
                lector = new StreamReader("Personas.txt");

                string linea = lector.ReadLine();
                arrayString = linea.Split(',');

                nuevaPersona = new Persona(arrayString[0], arrayString[1]);
                

            }
            catch (Exception)
            {
                
                throw;
            }
            finally
            {
                lector.Close();
            }
            
            return nuevaPersona;
        }


        public static List<Persona> RetornarListado()
        {

            List<Persona> miListado;

            try
            {
                miListado = new List<Persona>();

                using (StreamReader lector = new StreamReader("Personas.txt"))  //Al salir del using el archivo se cierra automaticamente, 
                {                                                               //sin necesidad de utilizar un finally con un .Close()
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
