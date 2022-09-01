using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypes_PracticeExercises.Entities
{
    public class Person
    {
        public string? Name { get; set; }

        public void ShowData(House house) { Console.WriteLine($"Ciao, il mio nome è {Name} and {house.ShowData} {house.GetDoor}"); }
    }
}
