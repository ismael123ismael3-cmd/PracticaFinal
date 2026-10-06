using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class PracticaN3
    {
        static unsafe void Main()
        {
            int nota = 47;
            int* pNota = &nota;

            Console.WriteLine("Nota antes de la revisión: " + nota);
            *pNota = *pNota + 5;
            Console.WriteLine("Nota después de la revisión: " + nota);

            if (*pNota >= 51)
            {
                Console.WriteLine("¡Aprobado!");
            }
            else
            {
                Console.WriteLine("Reprobado, a prepararse para el examen final");
            }
        }
    }
}
