using System;
using System.Globalization;

namespace aula14 {
  class Aula14 {
    static void Main(string[] args) {

      int idade, soma, count;
      double media;

      count = 0;
      soma  = 0;

      Console.WriteLine("Digite sua idade( idade < 0, sai do programa ): ");
      idade = int.Parse(Console.ReadLine());

      while ( idade >= 0 ) {
        soma += idade;
        count++;
        Console.WriteLine("Digite sua idade( idade < 0, sai do programa ): ");
        idade = int.Parse(Console.ReadLine());
      }
      
      if ( count == 0 ) {
        Console.WriteLine("Não foi possível calcular a média!");
      } else {
        media = (double) soma / count;
        Console.WriteLine("O valor da média: " + media.ToString("F2", CultureInfo.InvariantCulture));
      }

    }
  }
}