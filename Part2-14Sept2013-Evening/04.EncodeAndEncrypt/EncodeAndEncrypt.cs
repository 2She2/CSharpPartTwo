using System;
using System.Text;

namespace _04.EncodeAndEncrypt
{
    class EncodeAndEncrypt
    {
        static void Main()
        {
            // 100 Points

            string message = Console.ReadLine();
            string cypher = Console.ReadLine();
            string code;

            if (message.Length > cypher.Length)
            {
                code = EncryptLongMessage(message, cypher);
            }
            else
            {
                code = EncryptLongCypher(message, cypher);
            }

            string str = Encode(code + cypher);
            Console.WriteLine(str + cypher.Length);
        }

        static string Encode(string messToEncode)
        {
            int repCount = 1;
            StringBuilder encode = new StringBuilder();

            for (int i = 0; i < messToEncode.Length; i++)
            {
                repCount = 1;

                while (true)
                {
                    if (repCount + i < messToEncode.Length && messToEncode[i + repCount] == messToEncode[i])
                    {
                        repCount++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (repCount > 2)
                {
                    encode.Append(repCount);
                    encode.Append(messToEncode[i]);
                    i += repCount - 1;
                }
                else
                {
                    encode.Append(messToEncode[i]);
                }
            }

            return encode.ToString();
        }

        static string EncryptLongCypher(string mess, string cyph)
        {
            StringBuilder sb = new StringBuilder(mess);
            int shortCounter = 0;

            for (int i = 0; i < cyph.Length; i++)
            {
                int xor = (sb[shortCounter] - 'A') ^ (cyph[i] - 'A');
                sb[shortCounter] = (char)(xor + 'A');

                shortCounter++;
                if (shortCounter == mess.Length)
                {
                    shortCounter = 0;
                }
            }

            return sb.ToString();
        }

        static string EncryptLongMessage(string mess, string cyph)
        {
            StringBuilder sb = new StringBuilder(mess);
            int shortCounter = 0;

            for (int i = 0; i < sb.Length; i++)
            {
                int xor = (sb[i] - 'A') ^ (cyph[shortCounter] - 'A');
                sb[i] = (char)(xor + 'A');

                shortCounter++;
                if (shortCounter == cyph.Length)
                {
                    shortCounter = 0;
                }
            }

            return sb.ToString();
        }
    }
}
