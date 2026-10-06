using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN6
    {
        static unsafe void Main()
        {
            double total = 12.5;

            double*
             pTotal = &total;

            *pTotal =*pTotal+ 2.5;
            Console.WriteLine("Total a pagar: " + total + " Bs");

            if (*pTotal>14)
            {
                Console.WriteLine("Ojo: hoy te pasaste del presupuesto diario");
            }
            Console.WriteLine("Bytes del dato apuntado: " + sizeof(double));
        }
    }
}