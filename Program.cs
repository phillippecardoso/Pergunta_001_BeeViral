using System;

namespace Pergunta_001_BeeViral
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Calculo Fatorial\r");
      Console.WriteLine("------------------------\n");
      IniciaNovaRotina();

    }
    static void NovaRotina(){

      Console.Write("Digite um número inteiro não negativo para calcular o fatorial:");
      int numero = int.Parse(Console.ReadLine());
      if (numero < 0)
      {
        Console.WriteLine("O número não pode ser negativo !");
      }
      else
      {
        Console.WriteLine("O fatorial de " + numero + " é " + CalculaFatorial(numero));
        IniciaNovaRotina();
      }

    }
    static void IniciaNovaRotina(){
      NovaRotina();
    }
    static int CalculaFatorial(int numero)
    {

      if (numero == 0 || numero == 1)
      {
        return 1;
      }

      int fatorial, i;
      fatorial = numero;
      for (i = numero - 1; i >= 1; i--)
      {
        fatorial = fatorial * i;
      }

      return fatorial;
    }
  }
}
