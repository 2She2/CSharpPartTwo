// 07. Write a program that encodes and decodes a string using given encryption key (cipher).
//     The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or)
//     operation over the first letter of the string with the first of the key, the second – with the second, etc.
//     When the last key character is reached, the next is the first.

namespace _07.EncodeAndDecodeString
{
    using System;
    using System.Text;

    class EncodeAndDecodeString
    {
        static void Main()
        {
            string inputText = ReadInputText("Enter text: ");
            string cipher = ReadInputText("Enter cipher: ");
            string decryptedMessage = Encrypt(inputText, cipher);

            Console.WriteLine("Encrypted text:");
            Console.WriteLine(decryptedMessage);

            Console.WriteLine(new string('=', Console.WindowWidth - 1));

            Console.WriteLine("Decrypted text:");
            Console.WriteLine(Decrypt(decryptedMessage, cipher));
        }

        // Encrypt given text
        private static string Encrypt(string text, string cipher)
        {
            StringBuilder cypherBuilder = new StringBuilder();
            int cipherCounter = 0;

            // On each iteration the encrypted char is append to the string
            for (int i = 0; i < text.Length; i++)
            {
                char xor = (char)(text[i] ^ cipher[cipherCounter]);
                cypherBuilder.Append(xor);

                cipherCounter++;

                // If cipher string reaches it's length, we set it back to 0
                if (cipherCounter == cipher.Length)
                {
                    cipherCounter = 0;
                }
            }

            return cypherBuilder.ToString();
        }

        // Decrypt given text
        private static string Decrypt(string text, string cipher)
        {
            return Encrypt(text, cipher);
        }

        // Encrypt given text
        static private string ReadInputText(string message)
        {
            string inputText;

            Console.Write(message);
            inputText = Console.ReadLine();

            return inputText;
        }
    }
}
