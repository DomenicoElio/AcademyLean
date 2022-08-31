using System;
using CreatingTypes_PracticeExercises.Entities;

class Academy {
    static void Main() {

        Person person = new Person{ Name = "Domenico"};
        //simplified declaration of new obj from person class with implementation of name attribute
        SmallApartment greenDoor = new SmallApartment();
        greenDoor.area = 50;
        //longer declearation of obj with implementation of area  - keeping both to remember both

        person.ShowData();
        //calling ShowData method from the class person

    }
}
