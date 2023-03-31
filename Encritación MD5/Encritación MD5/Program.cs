using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encritación_MD5
{
    internal class Program
    {
        Encriptacion_Md5 md5= new Encriptacion_Md5();
        static void Main(string[] args)
        {
            Encriptacion_Md5 md5 = new Encriptacion_Md5();
            int resp;

            do
            {
                Console.WriteLine("Menú...\n1.Encriptar.\n2.Desencriptar.\nDigite una opcion...");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion < 1 || opcion >2)
                {
                    Console.WriteLine("Digite una opcion valida");
                }
                else if (opcion == 1)
                {
                    Console.WriteLine("***ENCRIPTACION***");
                    Console.WriteLine("Inserte el texto a Encriptar:");
                    string valor = Console.ReadLine();
                    Console.WriteLine(md5.Encriptar(valor));
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("***DESENCRIPTACION***");
                    Console.WriteLine("Inserte el texto a Desencriptar:");
                    string valor2 = Console.ReadLine();
                    Console.WriteLine(md5.Desencriptar(valor2));
                }
                Console.WriteLine("¿Desea continuar?\n1.Si\n2.Salir");
                resp=int.Parse(Console.ReadLine());
            } while (resp==1);

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
