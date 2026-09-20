using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.trabajo_Video_final
{
    public class funcion1
    {
        public static void saludar()
        {
            Console.WriteLine("Bienvenido a la clase nro 2");
        }



        public static void datos()
        {
            Console.WriteLine("Por favor dime tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre);
            Console.Write("Dime por favor cuantos años de experiencia tienes en c#");
            int experiencia = int.Parse(Console.ReadLine());
            Console.WriteLine("Dime un aproximado de tiempo que le dedicas a la programacion");
            double tiempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Muchas gracias " + nombre + " " + "Tu experiencia de " + experiencia + "años" + " " + " el tiempo que le dedicas  " + " " + tiempo + "min " + " " +
                                " sera un pilar fundamental para el desarrollo de la clase");
        }
        


        /*
         * Funciones
         */
        public static double Sumar(double a, double b)
        {
            return a + b;

        }

        public static double Restar(double a, double b)
        {
            return a - b;

        }

        public static double Multiplicar(double a, double b)
        {
            return a * b;

        }

        public static double Dividir(double a, double b)
        {
            return a / b;

        }

    }
}
