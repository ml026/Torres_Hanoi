using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    static class Hanoi
    {

        private static int numDiscos;
        private static Pila ini, fin, aux;
        //Atributo x 
        private static int numMovimientos;

        /*TODO: Implementar métodos*/
        private static void mover_disco(Pila a, Pila b)
        {
            if (fin.Size != numDiscos)
            {
                //Se mueve el del push . Fin, también el del push
                //a ->b
                if (!a.isEmpty())
                {
                    if (b.isEmpty())
                    {
                        b.push(a.pop());
                        numMovimientos++;
                        Console.WriteLine("Se ha movido" + b.Top.valor + " " + "de" + " " + a.Nombre + " " + "a" + " " + b.Nombre);
                    }
                    else if (a.Top.valor < b.Top.valor)
                    {
                        b.push(a.pop());
                        numMovimientos++;
                        Console.WriteLine("Se ha movido" + b.Top.valor + " " + "de" + " " + a.Nombre + " " + "a" + " " + b.Nombre);
                    }
                    else
                    {
                        a.push(b.pop());
                        numMovimientos++;
                        Console.WriteLine("Se ha movido" + a.Top.valor + " " + "de" + " " + b.Nombre + " " + "a" + " " + a.Nombre);
                    }

                }



                else //a vacia
                {
                    if (!b.isEmpty())
                    {
                        a.push(b.pop());
                        numMovimientos++;
                        Console.WriteLine("Se ha movido" + a.Top.valor + " " + "de" + " " + b.Nombre + "a" + " " + a.Nombre);
                    }
                }
            }
        }

        public static int iterativo(int n, Pila INI, Pila FIN, Pila AUX)
        {
            numDiscos = n;
            numMovimientos = 0;
            ini = INI;
            fin = FIN;
            aux = AUX;
            //No ini pilas, ni atributo ->fin.size!=n
            if (n % 2 != 0)
            {
                while (fin.Size != numDiscos)
                {
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }

            }

            else
            {
                while (fin.Size != numDiscos)
                {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);

                }
            }
            return numMovimientos;
        }

    }
}


