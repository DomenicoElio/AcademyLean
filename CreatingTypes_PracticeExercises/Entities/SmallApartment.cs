using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingTypes_PracticeExercises.Entities
{
    public class SmallApartment : House
    {
        public SmallApartment(int area) : base(area) { area = 50; }

    }
}
