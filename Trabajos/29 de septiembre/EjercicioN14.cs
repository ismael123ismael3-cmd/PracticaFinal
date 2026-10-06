using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN14
    {
        static unsafe void Main()
        {
            int[] lista = { 1, 2, 3, 4, 5, 6 };

            fixed (int* p = lista)
            {
                int* izq = p;
                int* der = p + lista.Length-1;
                while (izq<der)
                {
                    int aux = *izq;
                    *izq =*der;
                    *der = aux;
                    izq++;
                    der--;
                }
            }

            Console.Write("Orden para la defensa:");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(" " + lista[i]);
            }
            Console.WriteLine();
        }
    }
}