using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypes_PracticeExercises.Entities
{
    public class House //created entity house
    {
        public int Area { get; set; }

        public House(int area) { Area = area; }

        public void ShowData() { Console.WriteLine($"I am a house, my area is {Area} square meters"); }

        public void GetDoor(Door door) { }

    }
}
