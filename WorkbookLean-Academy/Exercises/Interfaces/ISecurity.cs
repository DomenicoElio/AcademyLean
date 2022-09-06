using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbookLean_Academy.Exercises.Interfaces
{
    public interface ISecurity
    {
        public string Encrypt();
        public string Decrypt();
    }
}
