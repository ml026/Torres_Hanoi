using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("¿Cuántos discos quieres?:");
            int num = Convert.ToInt32(Console.ReadLine());

            Pila ini = new Pila(num, "ini");
            Pila aux = new Pila("aux");
            Pila fin = new Pila("fin");

            int m = Hanoi.iterativo(num, ini, fin, aux);
            Console.WriteLine("Utiliza" + " " + m + " " + "movimientos");


            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey(); //Espera U presione tecla
        }
    }
}
