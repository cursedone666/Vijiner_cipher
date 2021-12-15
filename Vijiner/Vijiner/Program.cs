using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vijiner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = true;
            do
            {
                int numInAlphabet, displacement, j, f, keyNumbering = 0, option, choose;
                

                string result;
                Console.WriteLine("Choose option: \n 1. Encrypt text \n 2. Decrypt Text \n 6.Quit");
                option = int.Parse(Console.ReadLine());

                char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                if (option == 1)
                {
                    Console.WriteLine("Text Encryption");
                    do
                    {
                        Console.WriteLine("Enter text");
                        string input = Console.ReadLine();
                        Console.WriteLine("Enter key");
                        string Key = Console.ReadLine();

                        char[] inputMessage = input.ToCharArray();
                        char[] inputKey = Key.ToCharArray();



                        for (int i = 0; i < inputMessage.Length; i++)
                        {
                            for (j = 0; j < alphabet.Length; j++)
                            {
                                if (inputMessage[i] == alphabet[j])
                                {
                                    break;
                                }
                            }
                            if (j != 27)
                            {
                                numInAlphabet = j;

                                if (keyNumbering > inputKey.Length - 1)
                                {
                                    keyNumbering = 0;
                                }
                                for (f = 0; f < alphabet.Length; f++)
                                {
                                    if (inputKey[keyNumbering] == alphabet[f])
                                    {
                                        break;
                                    }
                                }

                                keyNumbering++;

                                if (f != 33)
                                {
                                    displacement = numInAlphabet + f;
                                }
                                else
                                {
                                    displacement = numInAlphabet;
                                }


                                if (displacement > 26)
                                {
                                    displacement = displacement - 26;
                                }

                                inputMessage[i] = alphabet[displacement];
                            }

                        }
                        result = new string(inputMessage);
                        Console.WriteLine($"Tour ecnrypted message: {result}");

                        Console.WriteLine("Do you wanna quit? \n 1. Yes \n 2. No");
                        option = int.Parse(Console.ReadLine());
                        if(option == 1)
                        {
                            Console.WriteLine("Quiting");
                            option = 3;
                        }
                        if (option == 2)
                        {
                            Console.WriteLine("Keep working");
                        }
                    } while (option != 3);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Decryption");
                    do
                    {
                        Console.WriteLine("Enter something do decrypt");
                        string input1 = Console.ReadLine();
                        Console.WriteLine("Enter key");
                        string Key1 = Console.ReadLine();

                        char[] inputMessage1 = input1.ToCharArray();
                        char[] inputKey1 = Key1.ToCharArray();

                        string originalText = "";

                        for (int i = 0; i < inputMessage1.Length && i < inputKey1.Length; i++)
                        {
                            int x = (inputMessage1[i] - inputKey1[i] + 26) % 26;
                            x += 'a';
                            originalText += (char)(x);
                        }
                        Console.WriteLine($"Your decryption: {originalText}");

                        Console.WriteLine("Do u wanna quit decryption? \n 1. Yes \n 2. No");
                        choose = int.Parse(Console.ReadLine());
                        if (choose == 1)
                        {
                            choose = 1;
                        }
                        if (choose == 2)
                        {
                            Console.WriteLine("Keep working");
                        }


                    } while (choose != 1);
                }else if (option == 6)
                {
                    Console.WriteLine("Quiting");
                    quit = false;
                }



            } while (quit);

        }
    }
}
