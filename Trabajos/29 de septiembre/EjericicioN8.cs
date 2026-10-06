using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN8
    {
        static unsafe void Main()
        {
            int asistencias = 0;
            int* pAsis =&asistencias;

            for (int dia = 1; dia <= 5; dia++)
            {
                *pAsis+=1;
                Console.WriteLine("Día " + dia + ": " + asistencias + " asistencias");
            }
            Console.WriteLine("Total de la semana: " +*pAsis+ " asistencias");
        }
    }
}