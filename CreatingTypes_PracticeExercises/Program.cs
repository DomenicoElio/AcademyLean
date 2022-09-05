using System;
using CreatingTypes_PracticeExercises.Entities;

class Academy {
    static void Main() {

        SmallApartment miniscule = new SmallApartment() { };
        //simplified declaration of new obj from person class with implementation of name attribute
        
        miniscule.Area = 50; // assigning 50 to area value for miniscule obj
        miniscule.ShowData(); //caling method ShowData of House

        //Encrypter mario = new Encrypter();
        //mario.Decrypt();
        //mario.Encrypt();

    }
}
