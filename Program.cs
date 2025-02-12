using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circulo
{
     class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Ingresa el radio");
            double r=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa pi");
            double p= double.Parse(Console.ReadLine());
            double A = (r * r) * p; 
            System.Console.WriteLine("El resultado es:" +A);
            Console.ReadKey(); 
        }
    }
}
