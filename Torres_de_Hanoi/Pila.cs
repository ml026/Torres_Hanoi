using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {

        //Creamos un list de discos. LLamado elementos
        public List<Disco> Elementos { get; set; }

        //Atributo que proporciona nombre a la pila
        //No get ; set porque solo consultar top (aunque puede tenerlo)
        public string Nombre { get; set; }



        //Creamos el constructor, que creará las dos pilas vacías
        public Pila(string n)
        {
            Nombre = n;
            Elementos = new List<Disco>();

        }

        //Creamos el constructor de la pila, que creará la pila inicial
        public Pila(int w, string n)
        {
            Nombre = n;
            Elementos = new List<Disco>();
            for (int i = w; i > 0; i--)
            {
                //Crea los diferentes  discos, con el tamaño que nos indica el for
                Disco d = new Disco();
                d.valor = i;
                push(d);
            }
        }

        //Método que nos devuelve el tamaño de la pila
        public int Size { get { return Elementos.Count; } }

        //Método que nos indica el elemento que hay a la parte de arriba
        public Disco Top
        {
            get
            {    //Comprueba si la pila está llena
                if (isEmpty() == false)
                {
                    //Si lo está devuelve el elemento que tenga más arriba 
                    return Elementos[Size - 1];
                }
                //Si no devuelve null, ya que estará vacía
                return null;

            }
        }


        //Método que añade los elementos a la pila
        public void push(Disco d)
        {
            Elementos.Add(d);

        }


        //Método que coge el elemento a mover
        public Disco pop()
        {
            //Se guarda el disco a mover, para no perderlo
            Disco dTop = Top;
            //Pude ser 0
            //Elimina el disco de la columna en la que estaba
            Elementos.RemoveAt(Size - 1);
            return dTop;
        }

        //Comprueba si la pila está vacía
        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;


        }

    }
}
