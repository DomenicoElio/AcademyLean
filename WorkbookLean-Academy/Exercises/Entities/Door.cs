using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkbookLean_Academy.Exercises.Entities
{
    public class Door
    {
        public Color Color { get; set; }
        public Door(Color color) { Color = color; }
        public void ShowData() { Console.WriteLine($"I am a door and my color is: {Color}"); }
    }
}
