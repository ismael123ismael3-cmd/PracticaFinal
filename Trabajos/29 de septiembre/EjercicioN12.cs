using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN12
    {
        static unsafe void Main()
        {
            int[] retraso = { 0, 10, 0, 15, 5 };
            int diasTarde = 0;
            int minutos = 0;

            fixed (int* inicio = retraso)
            {
                int* fin = inicio+retraso.Length;
                int* p = inicio;
                while (p<fin)
                {
                    if (*p > 0)
                    {
                        diasTarde++;
                        minutos += *p;
                    }
                    p++;
                }
            }

            Console.WriteLine("Días con retraso: " + diasTarde);
            Console.WriteLine("Minutos perdidos: " + minutos);
            Console.WriteLine("¿Salir más temprano? " + (diasTarde>2));
        }
    }
}