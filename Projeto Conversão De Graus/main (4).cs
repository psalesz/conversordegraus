using System;
using System.Globalization;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        char repetir = 'S';
        char nrepetir = 'N';
    
        while (repetir == 'S') {
        Console.WriteLine ("Digite uma temperatura em Celsius(C) para ser convertida:");
        double Tc = double.Parse(Console.ReadLine());
        
        double Tf;
        Tf = 9.0 * Tc / 5.0 + 32.0;
        
        Console.WriteLine("Equivalente Em Fahrennheit: " + Tf. ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("Deseja repetir a Conversão digite  S para Repetir e N para não repetir ");
          repetir = char.Parse(Console.ReadLine());
          }
          if (repetir == 'N') {
          Console.WriteLine("Seu Programa Para Conversão de Graus Celsius(C) para Fahrennheit(F) Está encerrado");
          }
          while (repetir != 'S') {
          Console.WriteLine("Digite Ou S ou N por favor...");
          repetir = char.Parse(Console.ReadLine());
          }
          if (repetir == 'S') {
          while (repetir == 'S') {
        Console.WriteLine ("Digite uma temperatura em Celsius(C) para ser convertida:");
        double Tc = double.Parse(Console.ReadLine());
        
        double Tf;
        Tf = 9.0 * Tc / 5.0 + 32.0;
        
        Console.WriteLine("Equivalente Em Fahrennheit: " + Tf. ToString("F1", CultureInfo.InvariantCulture));
        Console.WriteLine("Deseja repetir a Conversão digite  S para Repetir e N para não repetir ");
          repetir = char.Parse(Console.ReadLine());
          }
          if (repetir == 'N') {
          Console.WriteLine("Seu Programa Para Conversão de Graus Celsius(C) para Fahrennheit(F) Está encerrado");
          }
          }
    }
}
