using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WorkbookLean_Academy.Exercises.Interfaces;

namespace WorkbookLean_Academy.Exercises.Entities
{
    public class Encrypter : ISecurity
    {

        public string Encrypt()
        {
            string encrypt;
            Console.WriteLine("Insert the password you would like to encrypt: ");
            encrypt = Console.ReadLine();

            encrypt.Split(' ');

            for (int i = 0; i < encrypt.Length; i++)
            {
                Debug.Assert(encrypt.Length == 1 && Regex.IsMatch(encrypt, "[a-yA-y]"));
                var next = (char)(encrypt[0] + 1);
                next.ToString();
            }
            return encrypt;
        }

        public string Decrypt()
        {
            string decrypt;
            Console.WriteLine("Insert the word you would like to decrypt: ");
            decrypt = Console.ReadLine();

            decrypt.Split(' ');

            for (int i = 0; i < decrypt.Length; i++)
            {
                Debug.Assert(decrypt.Length == 1 && Regex.IsMatch(decrypt, "[a-yA-y]"));
                var next = (char)(decrypt[0] - 1);
                next.ToString();
            }
            return decrypt;
        }

    }
}
