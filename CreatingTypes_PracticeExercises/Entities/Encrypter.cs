using CreatingTypes_PracticeExercises.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CreatingTypes_PracticeExercises.Entities

{
    public class Encrypter : IEncrypter
    {
        public string Decrypt(string decrypt) {
            Console.WriteLine("Insert the word you would like to decrypt: ");
            decrypt = Console.ReadLine();

            decrypt.Split(' ');

            for (int i=0; i<decrypt.Length; i++) {
                Debug.Assert (decrypt.Length == 1 && Regex.IsMatch(decrypt, "[a-yA-y]"));
                var next = (char)(decrypt[0] + 1); 
                next.ToString(); }

            return decrypt;
        }

        public string Encrypt(string encrypt) { throw new NotImplementedException();  }

    }
}
