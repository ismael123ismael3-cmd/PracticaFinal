using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajos.trabajo_Video_final
{
    public class Ejercicio
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Bienvenido a Programacion II - Clase02");
            //saludar();
            funcion1.saludar();
            //Introducir Datos
            funcion1.datos();

            Console.WriteLine("Por favor introduce un valor para comprobar la calculadora en a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor introduce un valor para comprobar la calculadora en b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("La suma es" + " " + funcion1.Sumar(a, b));
            Console.WriteLine("La suma es" + " " + funcion1.Restar(a, b));
            Console.WriteLine("La suma es" + " " + funcion1.Multiplicar(a, b));
            Console.WriteLine("La suma es" + " " + funcion1.Dividir(a, b));


            /*
            Console.WriteLine("La suma es" +" " + Sumar(a, b));
            Console.WriteLine("La resta es" + " " + Restar(a, b));
            Console.WriteLine("La multiplicacion es" + " " + Multiplicar(a, b));
            Console.WriteLine("La division es" + " " + Dividir(a, b));
            */
                   /*Metodos
                    * 
                    * 
                    */


        }
    
    }
}