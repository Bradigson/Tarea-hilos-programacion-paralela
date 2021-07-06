using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaThread
{
    //Nombre: Bradigson
    //Matricula: 2018-6114
    class Program
    {
        public static void colmado1()
        {
            for(int i=0; i<=7; i++)
            {
                Console.WriteLine("despachando los clientes.... no:" + i);
            }
        }

        public static void colmado2()
        {
            for(int x=0; x<=5; x++)
            {

                Console.WriteLine("despachando los clientes.... no:" + x);
            }
        }
        static void Main(string[] args)
        {
            System.Threading.Thread colmadero1 = new System.Threading.Thread(new System.Threading.ThreadStart(colmado1));

            System.Threading.Thread colmadero2 = new System.Threading.Thread(new System.Threading.ThreadStart(colmado2));
       
            colmadero1.Start();
            Console.ForegroundColor = ConsoleColor.Yellow;
            colmadero2.Start();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ReadKey();

        }

    }

   
}
