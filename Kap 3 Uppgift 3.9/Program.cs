using System;
namespace Uppgift3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Definerar variabler
            double number1;
            double number2;
            double number3;

            int plus1Index;
            int plus2Index;
            
            //Beräkning från användaren
            Console.WriteLine("Skriv in en addition med ett eller två plustecken:");
            string calc = Console.ReadLine();

            plus1Index = calc.IndexOf("+"); //Index för första pluset
            number1 = double.Parse(calc[..plus1Index]); //Tal nummer 1

            string afterPlus1 = calc[(plus1Index + 1)..]; //String efter det första pluset

            bool plus2 = afterPlus1.Contains("+"); //Finns det ett andra plus?

            if (plus2 == true) //JA, det finns ett annat plus
            {
                plus2Index = afterPlus1.IndexOf("+"); //Index för plus nummer 2
                number2 = double.Parse(afterPlus1[..plus2Index]); //Nummer 2
                number3 = double.Parse(afterPlus1[(plus2Index + 1)..]); //Nummer 3

                Console.WriteLine($"{calc} = {number1 + number2 + number3}"); //Resultat
            }
            else //NEJ, det finns inget annat plus
            {
                number2 = double.Parse(afterPlus1); //Nummer 2

                Console.WriteLine($"{calc} = {number1 + number2}"); //Resultat
            }
        }
    }
}