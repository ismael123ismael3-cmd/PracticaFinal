using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN13
    {
        static unsafe void Intercambiar(int*a, int* b)
        {
            int aux =*a;
            *a = *b;

            *b = aux;
        }

        static unsafe void Main()
        {
            int miTurno = 2;
            int turnoCompa = 5;

            Console.WriteLine("Antes:   yo expongo en el turno " + miTurno + ", mi compañero en el " + turnoCompa);
            Intercambiar(&miTurno,&turnoCompa);
            Console.WriteLine("Después: yo expongo en el turno " + miTurno + ", mi compañero en el " + turnoCompa);
        }
    }
}