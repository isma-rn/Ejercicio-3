using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace E3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un entero positivo");
            try
            {
                uint numero = uint.Parse(Console.ReadLine());                
                Console.WriteLine("El factorial de {0}, es : \n{1:N0}", numero, Factorial(numero));                
            }
            catch(Exception e)
            {
                Console.WriteLine("Error, valor ingresado no válido: {0}", e.Message);
            }           
            
            Console.ReadLine();
        }

        public static BigInteger Factorial(uint fact)
        {
            if (fact > 2)
                return fact * Factorial(fact - 1);
            return fact == 2? 2:1;
        }
    }
}
