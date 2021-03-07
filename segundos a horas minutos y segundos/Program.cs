using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace segundos_a_horas_minutos_y_segundos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double segundosconv;
            double solucion1;
            double solucion2;
        
            Console.WriteLine("Escribe los segundos a convertir: ");
            segundosconv = Convert.ToDouble(Console.ReadLine ());


            solucion1 = segundosconv / 60;
            solucion2 = segundosconv / 60 / 60;

            Console.WriteLine("Este es el valor en horas: " + solucion2 +" "+"horas");
            Console.WriteLine("El valor en minutos es: " + solucion1 + " " + "minutos");



            Console.ReadKey();



        }
    }
}
