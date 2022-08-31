﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypes_PracticeExercises.Interfaces
{
    public interface IEncrypter
    {
        public string Encrypt(string encrypt);
        public string Decrypt(string decrypt);
    }
}
