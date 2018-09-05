using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =0;
            int b =10;
            int denominador = 0;
            int numerador = 0;
            int resultado = 0;

            try
            {
                Console.WriteLine("Ingrese un valor");
                numerador = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un segundo valor");
                denominador = Convert.ToInt32(Console.ReadLine());
                resultado = numerador / denominador;
                Console.WriteLine("El resultado es = " + resultado);
                Console.ReadKey();
               
            }
            catch (DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Intente introducir nuevos valores diferentes de cero");
            }
            catch(FormatException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Intente introducir valores que se solicitan");

            }
            catch(OverflowException error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine("Intente introducir valores dentro del rango");
            }
            Console.ReadKey();
        }
    }
}
