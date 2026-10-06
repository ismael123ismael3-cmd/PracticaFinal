using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class Ejercicio18
    {
        struct Estudiante
        {
            public int Codigo;
            public int Semestre;
            public int Creditos;
        }

        static unsafe void Main()
        {
            Estudiante e;
            e.Codigo = 2024153;
            e.Semestre = 3;
            e.Creditos = 48;

            Estudiante* pe =&e;
            pe->Creditos += 24;
            pe->Semestre = pe->Semestre+ 1;

            Console.WriteLine("Código:   " +pe->Codigo);
            Console.WriteLine("Semestre: " + (*pe).Semestre);
            Console.WriteLine("Créditos: " + e.Creditos);
        }
    }
}