using System;                   //Importing Namespace

class Test                      //Class Declaration
{
    static void Main()          //Method Declaration
    {
        /*int var = 15 * 10;      //Declearing and Initializing variable 
        Console.WriteLine($"Your Variable is worth: {var}"); //Print to Console command
        Console.WriteLine($"Your conversion result is: {FeetToInches(15)}");  //calling method and passing the feet value needed: 225
        Console.WriteLine($"Your conversion result is: {FeetToInches(150)}"); //calling method and passing the feet value needed: 2250
    }

    static int FeetToInches(int feet)
    { //creating method that converts feet to inch: accept feet (int feet) as imput
        int inches = feet * 15;
        return inches;                  // returns inches
    }*/

        string name = "domenico";    //first use of strings to store name
        string upperCase = name.ToUpper(); // calling the String method to Pascal case (upper first words) 
        Console.WriteLine($"My name is: {upperCase}"); //print name with upper

        string surname = " bressanello"; // declearing and initializing string variable 
        string person = name + surname.ToString(); //concatenation of strings using operator + and ToString() method
        Console.WriteLine($"My name is: {person}"); // printing full name

        bool sampleVar = false; // initializing bool to false
        if (sampleVar)          //passing my boolean variable as the condition will check if its true or false - if false it wont run
            Console.WriteLine("code will not execute"); // this wont be printed to the console

        int age = 25;
        bool lesser = age < 26; //boolean var decleared and initialized to true (because age is < then 26) 
        if (lesser)             //checks if lesser condition is true 
            Console.WriteLine("age is less then 26"); //because condition is true

    }
}                               // end of Class