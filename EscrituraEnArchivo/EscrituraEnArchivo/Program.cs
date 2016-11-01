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
            
            //--------------------------------------------------------

            Persona unaPersona = new Persona("Diego", "1234");
            Guardador.GuardarPersona(unaPersona);
            Guardador.LeerUnaPersona();


            Console.ReadKey();
            
            
        }
    }
}
