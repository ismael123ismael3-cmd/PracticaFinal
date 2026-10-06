using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN7
    {
        static unsafe void Main()
        {
            char aula = 'A';

            char*pAula =&aula
            ;

            Console.WriteLine("Aula de hoy:      " + *pAula);
            *pAula =(char)(*pAula + 1);
            Console.WriteLine("Aula de mañana:   " + aula);
            (*pAula)++;
            Console.WriteLine("Aula del jueves:  " + aula);
        }
    }
}