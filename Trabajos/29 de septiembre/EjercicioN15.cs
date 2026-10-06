using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN15
    {
        static unsafe int* BuscarMayor(int* p, int n)
        {
            int* mayor = p;
            for (int i = 1; i < n; i++)
            {
                if (*(p + i)>*mayor)
                {
                    mayor =p + i;
                }
            }
            return mayor;
        }

        static unsafe void Main()
        {
            int[] horas = { 4, 6, 3, 5 };

            fixed (int* p = horas)
            {
                int*masHoras = BuscarMayor(p, horas.Length);
                Console.WriteLine("Materia con más horas: N.º " + (masHoras - p + 1));
                Console.WriteLine("Horas por semana: " + *masHoras);
                *masHoras-= 2;
            }
            Console.WriteLine("Después de la convalidación: " + horas[1] + " horas");
        }
    }
}