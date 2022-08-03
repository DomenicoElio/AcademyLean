using System; //Importing Namespace
using WorkbookLean_Academy;

/*public class UnitConverter
{
    int ratio; //declearing variable
    public UnitConverter(int unitRatio) { ratio = unitRatio; }
    public int Convert(int unit) { return unit * ratio; } 
}*/

public struct Point { public int X, Y; }
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

        /*string name = "domenico";    //first use of strings to store name
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

        UnitConverter  feetToInchesCon = new UnitConverter(15); //instance of unitConverter class
        UnitConverter  milesToFeetCon = new UnitConverter(150); //instance of unitConverter class

        Console.WriteLine(feetToInchesCon.Convert(30)); //calling obj and method with .method
        Console.WriteLine(feetToInchesCon.Convert(300));//calling obj and method with .method
        Console.WriteLine(feetToInchesCon.Convert(milesToFeetCon.Convert(15)));*/

        Human dom = new Human("Domenico"); // created instances of my Human
        Human jack = new Human("Giacomo"); //created instances of my Human 

        Console.WriteLine($"The name of the first born son is: {dom.Name}"); // print human name
        Console.WriteLine($"The name of his brother is: {jack.Name}"); //print human name

        Console.WriteLine($"The total number of sons is: {Human.Population}"); //satic field has updated alongside number increase of obj thanks to: ({ Name = n; Population = Population + 1; })

        int var = 12345; //int is 32 bit Integer
        long implicitConversion = var; // long is 64 bit Integer (therefore, since it can hold an int data, conversion is implicit)
        short explicitConversion = (short)var; //short is 16 bit Integer (therefore, since it cannot hold the same amount or more data then and int, conversion requires a "cast" - basically its forced, it may not work and some data can be lost)

        Point point1 = new Point(); // assignment of value type instance will copy the value
        point1.X = 15;

        Point point2 = new Point();
        point2 = point1;           // assignment copies the value

        Console.WriteLine(point1.X); //15
        Console.WriteLine(point2.X); //15

        point1.X = 20;              // changing the value for p1 but not copying over to p2

        Console.WriteLine(point1.X); // p1 is 20
        Console.WriteLine(point2.X); //p2 remained 15


    }
}                               // end of Class