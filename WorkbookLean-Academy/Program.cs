using System; //Importing Namespace
using WorkbookLean_Academy;

/*public class UnitConverter
{
    int ratio; //declearing variable
    public UnitConverter(int unitRatio) { ratio = unitRatio; }
    public int Convert(int unit) { return unit * ratio; } 
}*/

public class Point { public int X, Y; }

//public struct Point { public int X, Y; }
class Test                      //Class Declaration
{

    static int Sum(params int[] ints) { 
        int sum = 0;
        for (int i = 0; i < ints.Length; i++) 
        sum += ints[i];
        return sum;
    }

    static void Splits(string name, out string firstName, out string lastName) { 
        int i = name.LastIndexOf(' ');
        firstName = name.Substring(0, i);
        lastName = name.Substring(i + 1);
    }

    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

    static string x = "Old Value";
    static ref string GetX() => ref x;

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

        /*Human dom = new Human("Domenico"); // created instances of my Human
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
        Console.WriteLine(point2.X); //p2 remained 15*/

        /*int x = 0, y = 0;
        Console.WriteLine(x++); // Outputs 0; x is now 1
        Console.WriteLine(++y); // Outputs 1; y is now 1

        int sample = 0; //difference between increment position (same with --)
        Console.WriteLine(sample++); // value of sample incremented by 1 after writeline completed (prints 0 increments value to 1)
        Console.WriteLine(++sample); // value increased by 1 more before function prints to terminal (value now 2 and prints 2)


        int a = 1000000;
        int b = 1000000;

        int c = checked(a * b); // Checks just the expression.

        checked // Checks all expressions
        { 
            c = a * b;// in statement block.
        } //the checked operator is useful to "check" for overflow in the value of integral variables (whether the result of an operation on them exceeds the maximum value the variable type can store, however it incurs a cost on performance)


        //int p = int.MaxValue + 1; // Compile-time error. this because we assign a value that is 1 higher then the max allowed, and variable is autormatically checked at runtime.
        int uncheck= unchecked(int.MaxValue + 1); // No errors because we remove the check.

        Console.WriteLine(double.IsNaN(0.0 / 0.0)); // necessary to test whether a value is NaN (not a number, can result only from floating point values)

        string bigName = "Domenico";
        Console.WriteLine($"my name is: {bigName}"); // work continued all to string interpolation and arrays*/

        /*char[] name = new char[4]; // declearing an array with 4 elements (characters)

        name[0] = 'd';
        name[1] = 'o';
        name[2] = 'm';
        name[3] = 'e';

        Console.WriteLine(name[1]);

        for (int i = 0; i < name.Length; i++) { Console.WriteLine(name[i]); }

        char[] letters = new char[] { 'a', 'b', 'c' }; //initialization statement in two types
        int[] numbers = { 1, 2, 3 };
        Console.WriteLine(numbers[0]);

        int[] defaultValue = new int[500]; //decleared but not initialized, all memory elements will default to 0
        Console.WriteLine(defaultValue[173]);

        /*Point[] f = new Point[500];
        int m = f[350].X;*/ //this example refers to the struct on line 13 and prints a value of 0

        /*Point[] point = new Point[500];
        for (int i = 0; i < point.Length; i++) { point[i] = new Point(); }*/
        // here the for iterated from 0 to 999 and here it assigns every iteration value with new point
        //an array, remains always a reference type, an array element can refer to a null value 

        /*char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        char[] firstTwo = vowels[..2]; // 'a', 'e'
        char[] lastThree = vowels[2..]; // 'i', 'o', 'u'
        char[] middleOne = vowels[2..3]; // 'i'

        //this use of ranges to slice through arrays can prove very valuable when looking for specific elements of an array 

        int[,] matrix = new int[3, 3];

        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = i * 3 + j;
        // sample declration rectangular array with 3x3 dimensions (rectangular arrays can have n dimesions)

        int[,] matrixReloaded = new int[,]
        {
        {0,1,2},
        {3,4,5},
        {6,7,8}
        };*/

        // this is the same array as before, simple initialized and decleared immediately

        /*int[][] jaggedMatrix = new int[3][];

        for (int i = 0; i < matrix.Length; i++)
        {
            jaggedMatrix[i] = new int[3]; 
            for (int j = 0; j < jaggedMatrix[i].Length; j++)
                jaggedMatrix[i][j] = i * 3 + j;
        }*/

        //jagged arrays, being arrays of arrays, require for the outermost dimensions (0,3 so array 3x3) to be specified when decleared
        //the inner array is then created

        /*static void Foo (int p) { 
        p = p+1;
            Console.WriteLine(p);}

        Foo(8);

        string x = "Penn";
        string y = "Teller";
        Swap(ref x, ref y);
        Console.WriteLine(x); // Teller
        Console.WriteLine(y); // Penn*/


        /*Splits("Domenico Elio", out string a, out string b);
        Console.WriteLine(a);
        Console.WriteLine(b);

        //int total = Sum(1, 2, 3, 4);
        int total = Sum(new int[] { 1, 2, 3, 4 });
        Console.WriteLine(total);


        ref string xRef = ref GetX(); 
        xRef = "New Value";
        Console.WriteLine(x);


        //as seen per all variable declaration and initialization, instead of specifying the type we can let the program infer the type and use var

        var name = "Domenico";
        Console.WriteLine(name); // in this case inferred type is a string

        //very important section on null operators in page 70 to keep in mind when working with nulls in general

        if (2 + 2 == 5)
            Console.WriteLine("Does not compute");
        else
            Console.WriteLine("False");
        //any if statement only computes if the first evaluation of the condition in parenthesis results true (a boolean expression).
        // using the else clause, code can be added that will only execute in case the first condition results as false.
        //it is especially important, if several conditions (nested) are being evaluated, to use braces in order to improve readability and control the execution flow properly.


        static void ShowCard(int cardNumber)
        {
            switch (cardNumber)
            {
                case 13:
                    Console.WriteLine("King");
                    break;
                case 12:
                    Console.WriteLine("Queen");
                    break;
                case 11:
                    Console.WriteLine("Jack");
                    break;
                case -1: 
                    goto case 12; 
                default: 
                    Console.WriteLine(cardNumber);
                    break;
            }
        }*/
        //although this is the example from the textbook, a switch statement can be used, for example, in console apps
        //to set up a pseudo menu of choices that the user can select, determining therefore program execution
        //a switch case can also stack conditions and evaluate conditions based on types (if x!int) instead of values


        /*int i = 15;
        while (i <= 20) 
        { Console.WriteLine(i); i++; }
        //a simple while statement will execute the code within after checking the condition (if condition is satsfied, in this case
        // if i was 21) the while will consider the condition satsfied and not execude the code.


        int example = 10;
        do { Console.WriteLine(example); example++; }
        while (example <= 20);
        //on the contrary, a do while will always initially print the first time (the do) and only continue with the exectuion
        //after checking the condition in the while (after).

        int examples = 20;
        for (int n = 0; n <= examples; n++) { Console.WriteLine(n); }
        //a for is used to evaluate a condition based on a variable and perform a set of operation

        string masterName="Domenico Elio";
        foreach (char d in masterName) { Console.WriteLine(d); }
        //the same goes for a foreach statement, however this is only used to iterate over elemnts of an enumerable object (such as a string in this case)*/




    }
}                               // end of Class