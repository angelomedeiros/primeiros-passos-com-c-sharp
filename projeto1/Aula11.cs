using System;

namespace aula11 {
  class Aula11 {
    static void Main(string[] args) {
      string tipoString;
      int tipoInt;
      double tipoDouble;
      char tipoChar;

      tipoString = Console.ReadLine();
      tipoInt    = int.Parse(Console.ReadLine());
      tipoDouble = double.Parse(Console.ReadLine());
      tipoChar   = char.Parse(Console.ReadLine());

      Console.WriteLine(tipoString);
      Console.WriteLine(tipoInt);
      Console.WriteLine(tipoDouble);
      Console.WriteLine(tipoChar);

    }
  }
}