using System;
using System.Collections.Generic;
using System.IO;

namespace DialPad
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<string, int> myDictionary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
                myDictionary = MapNumbersAndLetters();

                Console.WriteLine("IN:" + Environment.NewLine);

                string textReaderText = "5551234" + Environment.NewLine + "GOPANDA" + Environment.NewLine + "MebiPenny2012";
               
                Console.WriteLine(textReaderText);

                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("OUT:" + Environment.NewLine);

                using (StringReader reader = new StringReader(textReaderText))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            string s = line[i].ToString();
                            int result = 0;
                            if (Int32.TryParse(s, out result) == false)
                            {
                                // not a number, find the number by it's letter
                                var value = myDictionary[s];
                                Console.Write(value);
                            }
                            else // number
                            {
                                Console.Write(s); 
                            }
                        }
                        
                        Console.Write(Environment.NewLine);
                    }
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error Occured" + ex.InnerException + " " + ex.Message);
                Console.ReadLine();
            }
        }

        static public Dictionary<string, int> MapNumbersAndLetters()
        {
            Dictionary<string, int> myDictionary = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            // 2 = ABC
            myDictionary.Add("A", 2);
            myDictionary.Add("B", 2);
            myDictionary.Add("C", 2);

            // 3 = DEF
            myDictionary.Add("D", 3);
            myDictionary.Add("E", 3);
            myDictionary.Add("F", 3);

            // 4 = GHI
            myDictionary.Add("G", 4);
            myDictionary.Add("H", 4);
            myDictionary.Add("I", 4);

            // 5 = JKL
            myDictionary.Add("J", 5);
            myDictionary.Add("K", 5);
            myDictionary.Add("L", 5);

            // 6 = MNO
            myDictionary.Add("M", 6);
            myDictionary.Add("N", 6);
            myDictionary.Add("O", 6);

            // 7 = PQRS
            myDictionary.Add("P", 7);
            myDictionary.Add("Q", 7);
            myDictionary.Add("R", 7);
            myDictionary.Add("S", 7);

            // 8 = TUV
            myDictionary.Add("T", 8);
            myDictionary.Add("U", 8);
            myDictionary.Add("V", 8);

            // 9 = WXYZ
            myDictionary.Add("W", 9);
            myDictionary.Add("X", 9);
            myDictionary.Add("Y", 9);
            myDictionary.Add("Z", 9);

            return myDictionary;
        }
    }
}