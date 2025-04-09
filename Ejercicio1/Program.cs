using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int suma;
            Console.Write("Ingrese numero 1: ");
            num1=int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2: ");
            num2=int.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("La suma es: "+suma);
            
            //Console.ReadKey();
        }
    }
}
