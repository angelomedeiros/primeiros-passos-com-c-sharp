using System;

namespace aula12 {
  class Aula12 {
    static void Main(string[] args) {
      double a;
      double b;
      double c;
      double x1;
      double x2;
      double delta;

      Console.WriteLine("Digite o valor de a: ");
      a = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor de b: ");
      b = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor de c: ");
      c = double.Parse(Console.ReadLine());

      delta = Math.Pow(b, 2) - 4 * a * c;

      if ( delta > 0 ) {
        x1 =  (- b + Math.Sqrt(delta)) / 2 * a;
        x2 =  (- b - Math.Sqrt(delta)) / 2 * a;
        Console.WriteLine( "O valor de x1 é " + x1 + " e o valor de x2 é " + x2 );
      } else if ( delta == 0 ) {
        x1 =  - b / 2 * a;
        Console.WriteLine( "O valor de x1 e x2 é " + x1 );
      } else {
        Console.WriteLine("A equação não possui raiz no conjunto dos números reais!");
      }

      Console.ReadLine();
    }
  }
}