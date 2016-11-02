using System;
using System.Collections.Generic;
using System.IO; //necesario para streamreader
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EscrituraEnArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter objStreamW = new StreamWriter("Archivo.txt");
            objStreamW.Write("Hola");
            objStreamW.Close();
            
            

            StreamReader objStreamR = new StreamReader("Archivo.txt");
            Console.WriteLine(objStreamR.ReadLine());
            //--------------------------------------------------------

            /*
            //Persona unaPersona = new Persona("Diego", "1234");
            Persona unaPersona = new Persona("Fede", "666");

            Console.WriteLine("\nGuardo una persona");
            Guardador.GuardarPersona(unaPersona);

            Console.WriteLine("Leo la persona");
            Persona otraPersona = Guardador.LeerUnaPersona();
            
            Console.WriteLine(otraPersona);
            */
            Console.WriteLine("Retorno listado");
            List<Persona> Lista = Guardador.RetornarListado();

            foreach (Persona item in Lista)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
            
            
        }
    }
}
