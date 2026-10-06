using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN16
    {
        static unsafe void Main()
        {
            const int DIAS = 6;
            int* megas =stackalloc int[DIAS];
            megas[0] = 3000;

            for (int d = 1; d < DIAS; d++)
            {
                *(megas + d) = *(megas + d - 1) - 450;
            }

            for (int d = 0; d < DIAS; d++)
            {
                Console.Write("Día " + (d + 1) + ": " + megas[d] + " MB");
                if (megas[d]< 1000)
                {
                    Console.Write("  <- recargar pronto");
                }
                Console.WriteLine();
            }
        }
    }
}