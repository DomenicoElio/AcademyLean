using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkbookLean_Academy.Exercises.Entities;

namespace WorkbookLean_Academy
{
    public class House
    {
        public int Area { get; set; }

        public House() { }
        public House(int area) { Area = area; }

        public void ShowData() { Console.WriteLine($"I am a house, my area is {Area} square meters"); }

        public void GetDoor(Door door) { Console.WriteLine($"The door necessary to open this house is {door.Color.ToString()}"); }

    }

}
