using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjericicioN10
    {
        static unsafe void Main()
        {
            int[] precios = { 5, 7, 15, 6 };


            fixed(int* p = precios)
            {
                int* q =p + 2;
                Console.WriteLine("Precio del almuerzo: " + *q + " Bs");
                Console.WriteLine("Distancia en elementos: " + (q - p));
                Console.WriteLine("Distancia en bytes:     " + (q - p) *sizeof(int));
            }
        }
    }
}