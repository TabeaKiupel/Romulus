using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace romulus
{
    public class Converter
    {
        public int inputNumberAsInt;

        string[] actualMap;
        //StringBuilder actualRomanString = new StringBuilder();

        int divider = 5;
        int moduloRest = 4;

        string[][] mapOfMaps = 
        {
            new string[] {"I", "IV", "V", "IX"},
            new string[] {"X", "XL", "L", "XC"},
            new string[] {"C", "CD", "D", "CM"},
            new string[] {"M"}
        };

        public Converter() { }
        
        /*public void setInputNumberAsInt(int input)
        {
            inputNumberAsInt = input;
        }
        */
        public int getInputNumberAsInt()
        {
            return inputNumberAsInt;
        }

        public void convert(int number)
        {
            int decimalNumber = number;
            int lengthOfNumber = decimalNumber.ToString().Length;

            StringBuilder romanNumber = new StringBuilder();
            StringBuilder romanNumberOnes = new StringBuilder();
            StringBuilder romanNumberTens = new StringBuilder();
            StringBuilder romanNumberHundreds = new StringBuilder();
            StringBuilder romanNumberThousands = new StringBuilder();
            StringBuilder actualRomanString = new StringBuilder();

            int[] splitNumber = new int[4];
            splitNumber[3] = decimalNumber / 1000; //tausender
            splitNumber[2] = decimalNumber % 1000 / 100; //hunderter
            splitNumber[1] = decimalNumber % 100 / 10; //zehner
            splitNumber[0] = decimalNumber % 10; //einser

            for (int i = lengthOfNumber; i >= 0; i--)
            {
                actualRomanString.Clear();
                int partOfNumber = i - 1;
                if (i == 0)
                {
                    Console.WriteLine(romanNumber);
                    return;
                }
                else
                {
                    int actualNumber = splitNumber[partOfNumber];
                    switch (partOfNumber)
                    {
                        case 3:
                            actualMap = mapOfMaps[3];
                            break;
                        case 2:
                            actualMap = mapOfMaps[2];
                            break;
                        case 1:
                            actualMap = mapOfMaps[1];
                            break;
                        case 0:
                            actualMap = mapOfMaps[0];
                            break;
                    }

                    int rest = actualNumber % divider;
                    if (actualNumber / divider > 0)
                    {
                        //Merke dritten Eintrag aus Map
                        actualRomanString.Append(actualMap[2]);

                        if (rest < moduloRest)
                        {
                            if (rest > 0)
                            {
                                for(int j = rest; j > 0; j--)
                                {
                                    // erster Eintrag der Map an Ergebniss dran hängen
                                    actualRomanString.Append(actualMap[0]);
                                }
                            }
                        }
                        else
                        {
                            // vergiss dritten Eintrag aus Map
                            string textToRemove = actualMap[2];
                            int pos = actualRomanString.ToString().IndexOf(textToRemove);
                            actualRomanString.Remove(pos, textToRemove.Length);

                            // Merke vierten Eintrag aus Map
                            actualRomanString.Append(actualMap[3]);

                        }
                    }
                    else
                    {
                        if (rest < moduloRest)
                        {
                            for (int j = rest; j > 0; j--)
                            {
                                // erster Eintrag der Map an Ergebniss dran hängen
                                actualRomanString.Append(actualMap[0]);
                            }
                        }
                        else
                        {
                            //Merke zweiten Eintrag aus aktueller Map
                            actualRomanString.Append(actualMap[1]);
                        }
                    }
                }
                romanNumber.Append(actualRomanString);
            }

        }

        public bool inputIsCorrect(string input)
        {
            if (Int32.TryParse(input, out inputNumberAsInt))
            {
                if (inputNumberAsInt < 4000 && inputNumberAsInt > 0)
                {
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
