using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypes_PracticeExercises.Interfaces
{
    public interface IEncrypter
    {
        public string Encrypt(string encrypted);
        public string Decrypt(string decpryted);
    }
}
