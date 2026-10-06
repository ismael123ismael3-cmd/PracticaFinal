using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN11
    {
        static unsafe void Main()
        {
            int[] practicas = { 70, 85, 60, 90, 75 };
            int total = 0;

            fixed (int* p = practicas)
            {
                for (int i = 0; i < practicas.Length; i++)
                {
                    Console.WriteLine("Práctica " + (i + 1) + ": " +*(p + i));
                    total+=*(p + i);
                }
            }

            int promedio = total/practicas.Length;
            Console.WriteLine("Total de puntos: " + total);
            Console.WriteLine("Promedio de prácticas: " + promedio);
        }
    }
}