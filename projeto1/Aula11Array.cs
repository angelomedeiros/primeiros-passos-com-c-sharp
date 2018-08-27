using System;

namespace aula11 {
  class Aula11Array {
    static void Main(string[] args) {

      string tipoString;
      int tipoInt;
      double tipoDouble;

      string[] vet = Console.ReadLine().Split(' ');

      tipoString = vet[0];
      tipoInt    = int.Parse(vet[1]);
      tipoDouble = double.Parse(vet[2]);

      Console.WriteLine(tipoString);
      Console.WriteLine(tipoInt);
      Console.WriteLine(tipoDouble);

    }
  }
}