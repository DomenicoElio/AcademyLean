using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbookLean_Academy
{
    public class Human
    {

        public string Name; // property per each human (instance field - must be instanciated whenever i create a new instance of "Human" or obj)
        public static int Population; //properties of the human class (static field - does not need to be instanciated every time i create an obj, its instrinsic to the class)

        public Human(string n)   // constructor of Human class
        { Name = n; Population = Population + 1; } //per each human created increment static value of population

    }
}
