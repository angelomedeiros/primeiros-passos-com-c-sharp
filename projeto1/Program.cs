using System;
using System.Globalization;

namespace projeto1{
    class Program{
        static void Main(string[] args){
            double x = 3.141592;

            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F5"));
            Console.WriteLine(x.ToString("F5", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de x: " + x.ToString("F5", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
