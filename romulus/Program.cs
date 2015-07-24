using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace romulus
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = false;

            do
            {
                string input;
                Console.WriteLine("Type in decimal number: ");
                input = Console.ReadLine();
                if (inputIsCorrect(input))
                {
                    // convert(input)
                }

                // do-while-Schleife für Wiederholung der "Nochmal"-Frage
                bool repeatQuestion = false;
                do
                {
                    Console.WriteLine("Nochmal? J/N");
                    string repeatInput;

                    repeatInput = Console.ReadLine();
                    if (repeatInput == "J" || repeatInput == "j")
                    {
                        repeat = true;
                        repeatQuestion = false;
                    }
                    else if (repeatInput == "N" || repeatInput == "n")
                    {
                        repeat = false;
                        repeatQuestion = false;
                    }
                    else
                    {
                        repeat = true;
                        repeatQuestion = true;
                    }
                } while (repeatQuestion);
            } while (repeat);
        }
        static bool inputIsCorrect(string input)
        {         
            int inputAsInt;

            if (Int32.TryParse(input, out inputAsInt))
            {
                if (inputAsInt < 4000 && inputAsInt > 0)
                {
                    Console.WriteLine(inputAsInt);
                    return true;
                }
                else
                {
                    Console.WriteLine("Ungueltige Zahl angegeben. Zahl muss im Bereich 1 bis 3999 sein.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Ungueltige Eingabe. Bitte nur eine Dezimalzahl eingeben.");
                return false;
            }
        }
    }
}
