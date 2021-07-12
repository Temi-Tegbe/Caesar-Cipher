using System;


namespace CaesarCipher
{
    class Program
    {

        public static char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);

        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;
            foreach (char ch in input)
                output += Cipher(ch, key);
            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("What do you want to do? e for encrypt | d for decrypt");
            string answer = Console.ReadLine();
            if (answer == "e")
            {


                Console.WriteLine("Type a string to encrypt:");
                string UserString = Console.ReadLine();

                Console.WriteLine("\n");

                Console.WriteLine("Enter your Key:");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Encrypted Data");

                string cipherText = Encipher(UserString, key);
                Console.WriteLine(cipherText);
                Console.WriteLine("\n");

            }
            if (answer == "d")
            {
                Console.WriteLine("Type a string to decrypt:");
                string UserString = Console.ReadLine();

                Console.WriteLine("\n");

                Console.WriteLine("Enter your Key:");
                int key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Decrypted Data:");
                

                string cipherText = Decipher(UserString, key);
                Console.WriteLine(cipherText);
                Console.WriteLine("\n");

                //string t = Decipher(cipherText, key);
                
                Console.Write("\n");

                Console.ReadKey();

            }
        }
    }

    }

