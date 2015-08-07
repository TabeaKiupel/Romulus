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
            Converter converter = new Converter();
            do
            {
                string input;
                int numberToConvert;//maybe

                Console.WriteLine("Type in decimal number: ");
                input = Console.ReadLine();

                if (converter.inputIsCorrect(input))
                {
                    numberToConvert = converter.getInputNumberAsInt();//maybe in convert function, so we don't need a parameter for convert-function
                    converter.convert(numberToConvert);
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
    }
}
