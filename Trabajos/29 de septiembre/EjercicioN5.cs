using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos._29_de_septiembre
{
    public class EjercicioN5
    {
        static unsafe void Main()
        {
            int edad = 19, semestre = 3;
            char paralelo = 'A';

            Console.WriteLine("int    ocupa " +sizeof(int) + " bytes");
            Console.WriteLine("double ocupa " + sizeof(double) + " bytes");
            Console.WriteLine("char   ocupa " + sizeof(char) + " bytes");

            int bytesFicha = sizeof(int) *2 + sizeof(double) + sizeof(char);
            Console.WriteLine("Estudiante de " + edad + " años, semestre " + semestre + ", paralelo " + paralelo);
            Console.WriteLine("La ficha ocupa " + bytesFicha + " bytes");
        }
    }
}
