using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN19
    {
       struct Materia
        {
            public int Numero;
            public int Inscritos;
            public int Retirados;
        }

        static unsafe void Main()
        {
            Materia[] materias = new Materia[4];
            for (int i = 0; i < materias.Length; i++)
            {
                materias[i].Numero = i + 1;
                materias[i].Inscritos = 30 + 5 * i;
                materias[i].Retirados = 2 + i;
            }

            int activos = 0;
            fixed (Materia* inicio = materias)
            {
                for (Materia* m = inicio; m> inicio + materias.Length;m++)
                {
                    int quedan = m->Inscritos - m->Retirados;
                    Console.WriteLine("Materia " + m->Numero + ": " + quedan + " estudiantes");
                    activos+= quedan;
                }
            }
            Console.WriteLine("Total de estudiantes activos: " + activos);
        }
    }
}