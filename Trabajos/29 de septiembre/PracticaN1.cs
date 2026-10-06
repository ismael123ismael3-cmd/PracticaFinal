using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class PracticaN1
    {
        static unsafe void Main()
        {
            int codigo = 2024153;

            int* pCod = &codigo;

            Console.WriteLine("Código en la variable: " + codigo);
            Console.WriteLine("Código con el puntero: " + *pCod);
            Console.WriteLine("¿Es el mismo? " + (codigo==*pCod));
        }
    }
}
