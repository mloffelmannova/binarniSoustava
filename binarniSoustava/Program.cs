
using System;

while (true)
{
  Console.ForegroundColor = ConsoleColor.DarkRed;
  Console.WriteLine("ZADEJ CO CHCEŠ PŘEVÁDĚT: ");

  Console.ForegroundColor = ConsoleColor.Red;
  string binaryNumber = Console.ReadLine();
  int volba = 0;
  int baseValue = 1;

  if (volba > 11111111)
    {
        Console.WriteLine("ŠPATNĚ ZADANÁ HODNOTA !!!");
        break;
    }
 else
    {
       for (int i = binaryNumber.Length - 1; i >= 0; i--)
       {
            int bit = binaryNumber[i] - '0';
            volba += bit * baseValue;
            baseValue *= 2;
       }
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("TVOJE ČÍSLO VE DVOJKOVÉ SOUSTAVĚ JE: " + volba);
    Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - -");
    }
}