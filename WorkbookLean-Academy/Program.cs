using System;                   //Importing Namespace

class Test                      //Class Declaration
{
    static void Main()          //Method Declaration
    {
        /*int var = 15 * 10;      //Declearing and Initializing variable 
        Console.WriteLine($"Your Variable is worth: {var}"); //Print to Console command*/
        Console.WriteLine($"Your conversion result is: {FeetToInches(15)}");  //calling method and passing the feet value needed: 225
        Console.WriteLine($"Your conversion result is: {FeetToInches(150)}"); //calling method and passing the feet value needed: 2250
    }

    static int FeetToInches(int feet)
    { //creating method that converts feet to inch: accept feet (int feet) as imput
        int inches = feet * 15;
        return inches;                  // returns inches
    }
}                               // end of Class