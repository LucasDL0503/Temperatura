using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
  
  String entrada; 
Double F, C; 
Console.WriteLine ("Digite a temperatura em Fahrenheit:");
entrada = Console.ReadLine();
F = Double.Parse(entrada);
C = 5.0/9.0* (F-32.0);
Console.WriteLine ("Celsius" + C );
  }
  } 


