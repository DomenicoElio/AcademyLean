using System;
using System.Text;
using WorkbookLean_Academy;

public struct KeyValuePair<TKey, TValue>
{
    public TKey Key { get; }
    public TValue Value { get; }
}
public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
    T this[int index] { get; set; }
    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
}
public interface IEnumerator{
    bool MoveNext();
    object Current { get; }
    void Reset();
}
//defines the order in which the elements of the collection are trasversed

public interface IEnumerable{
    IEnumerator GetEnumerator();
}
//this definition allows for more flexibility, the logic is implemented separetely

public class Human
{
    public string Name; // property per each human (instance field - must be instanciated whenever i create a new instance of "Human" or obj)
    public static int Population; //properties of the human class (static field - does not need to be instanciated every time i create an obj, its instrinsic to the class)

    public Human(string n)   // constructor of Human class
    { Name = n; Population = Population + 1; } //per each human created increment static value of population
}

public class UnitConverter
{
    int ratio; //declearing variable
    public UnitConverter(int unitRatio) { ratio = unitRatio; }
    public int Convert(int unit) { return unit * ratio; } 
}

public class TopLevel{
    public class Nested { } // Nested class
    public enum Color { Red, Blue, Tan } // Nested enum
}
//it is fundamental that the underlying advantage of using nested types (for enums) is that not only do they gain access to the 
//methods of the broader class they are decleared in, but they also gain access to the use of a wider range of access modifiers.
//a nested type should be considered when one wants to retain better control over access, not to avoid cluttering!


[Flags]
enum BorderSides { None = 0, Left = 1, Right = 2, Top = 4, Bottom = 8 }
public struct Point{
    int x, y;
    public Point(int x, int y) { this.x = x; this.y = y; }
}
//sample of a struct - compared to classes, a struct doesnt support inheritance and its members cannot be initialized

public class Animal { public string ?name; public virtual string  AnimalSounds => "sounds";}
//parent class lion with name
//?name the ?represents that the value type variable can be a nullable type or null value
public class Lion : Animal { public int numberOfLegs; public override string AnimalSounds => "roar"; }
//lion class extends parent animal class and inherits name field
public class Baboon : Animal { public bool similarToHumans; public override string AnimalSounds => "speak"; }
//baboon class extends parent animal class and inherits name field

public abstract class Assets { public abstract decimal MarketDifferentiation { get; } }
public class FashionIndustry : Assets { 
    public int numberOfBrands; 
    public int numberOfProducts;
    public override decimal MarketDifferentiation => (numberOfBrands * numberOfProducts) / 2; }
class SampleInitialization
{
    public static int X = Y; 
    public static int Y = 3; 
}

class AlternativeInitialization { 
    public static AlternativeInitialization Instance = new AlternativeInitialization();
    public static int X = 3;
    AlternativeInitialization() { Console.WriteLine(X); } 
}

public class Sentence{
    string[] words = "the wolf eats the sheep".Split();
    //calling .Split() method to split the string 
    public string this[int wordNum] { //defining the indexer
        get { return words[wordNum]; } //getter takes and returnd the number of words (string already split)
        set { words[wordNum] = value; } // set gives the value of the get to the variable word (one of the words from the split string is taken and replaced based on index position)
    }
}

public class Wallet {
    decimal currentBalance;

    decimal overallValue, marketPrediction;

    decimal marketSize = 150.34539423M;
    public decimal OverallValue { 
        get { return overallValue * marketPrediction; }
    }
    //sample of a read-only calculated prpoperty.
    //read-only cause only the getter is specified and calculated because the value is the result of an expression
    
    public decimal MarketCap { 
        get => marketSize % overallValue;
        set => marketSize = marketSize * marketPrediction;
    }

    //sample implementation of expression bodied properties using cleaner syntax and integrating the setter
    //(current property is only an example, mathematically non-sensical. will be fixed)

    public decimal CurrentBalance{ 
        get { return currentBalance; }
        set { currentBalance = value; }
    }
}

//sample property. difference with fields lies in the presence of the getter and setter accessors
//getter and setter can have different access modifiers.
//sample: get {return currentBalance;} internal set {currentBalange-marketEvaluation;}


public class Dog{
    public string name;
    public bool lovesHuman;
    public bool likesCats;

    public Dog() { }
    public Dog(string n) { name = n; }
}

public class Monkey {
    public Monkey Partner;

    public void BecomeCouple(Monkey mate) { 
        Partner = mate;
        mate.Partner = this;
    }
}


public class Square {
    public readonly float Width,Height;

    public Square(float width, float height) {
        Width = width;
        Height = height;
    }
    public void Deconstruct(out float width, out float height)
    {
        width = Width;
        height = Height;
    }
}


public class Humanity { 
    string named; //definition of the field
    public Humanity(string n) { //definition of the constructor
        named = n; //initialization code
    } 
    //same constructor could be also written as:
    //public Human (string n) => named = n; (expression bodied statement)
}
//public class Point { public int X, Y; }

//public struct Point { public int X, Y; } 
public class Program                      //Class Declaration
{
    string firstName;
    public Program(string firstName) { this.firstName = firstName; }

    //sample use this. reference with the monkey class


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
    //static ref string GetX() => ref x;

    static void Main() {           //Method Declaration
        int var = 15 * 10;      //Declearing and Initializing variable 
        Console.WriteLine($"Your Variable is worth: {var}"); //Print to Console command
        Console.WriteLine($"Your conversion result is: {FeetToInches(15)}");  //calling method and passing the feet value needed: 225
        Console.WriteLine($"Your conversion result is: {FeetToInches(150)}"); //calling method and passing the feet value needed: 2250

    static int FeetToInches(int feet)
        { //creating method that converts feet to inch: accept feet (int feet) as imput
            int inches = feet * 15;
            return inches;                  // returns inches
        }

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

        static void Foo (int p) { 
        p = p+1;
            Console.WriteLine(p);}

        Foo(8);

        string x = "Penn";
        string y = "Teller";
        Swap(ref x, ref y);
        Console.WriteLine(x); // Teller
        Console.WriteLine(y); // Penn


        Splits("Domenico Elio", out string a, out string b);
        Console.WriteLine(a);
        Console.WriteLine(b);

        //int total = Sum(1, 2, 3, 4);
        int total = Sum(new int[] { 1, 2, 3, 4 });
        Console.WriteLine(total);


        /*ref string xRef = ref GetX(); 
        xRef = "New Value";
        Console.WriteLine(x);*/
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
        }
        //although this is the example from the textbook, a switch statement can be used, for example, in console apps
        //to set up a pseudo menu of choices that the user can select, determining therefore program execution
        //a switch case can also stack conditions and evaluate conditions based on types (if x!int) instead of values


        int i = 15;
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
        //the same goes for a foreach statement, however this is only used to iterate over elemnts of an enumerable object (such as a string in this case)

        //first pages of work on classes and methods - so far mostly theory so no relevant code written.

        Humanity domenico = new Humanity("Domenico"); //constrctor created above in the human class. first example of a constructor


        var matrcx = new Square(10, 20);
        (float width, float height) = matrcx; // deconstructor is called
        Console.WriteLine(width+ "" + height); //the values passed will be printed


        Dog nano = new Dog { name = "nano", lovesHuman = true, likesCats = false };
        Dog ciack = new Dog("Ciack") { lovesHuman = true, likesCats = false };

        //both of these examples using the class dog show how its possible to build an object
        //using object initializers. It is important to ditinguish and evaluate between object initializers and optional parameters.

        Wallet nftStorage = new Wallet();
        nftStorage.CurrentBalance = 150;
        nftStorage.CurrentBalance -= 350;
        Console.WriteLine(nftStorage.CurrentBalance);
        //sample of a class's property. how to define and initialize it.
        //property is read-only if it only specifies the getter - write only if it only specifies the setter

        string indexersExamples="Mario Palladino";
        Console.WriteLine(indexersExamples[9]);
        string nullSample = null;
        Console.WriteLine(nullSample?[0]);
        //whilst the syntax is similar to arrays (points to a specific position of an index calling the, in this case,
        //variable, and specifying the [position] it is different as they access via an index argument. pg. 102)
        //indexers can be called null, as shown (nothing will show -null-)

        Sentence sentence = new Sentence();//creating obj of Sentence class 
        Console.WriteLine(sentence[4]);//using indexer to print original value of word in position [4] from split string 
        sentence[4] = "Sharks"; //replacing the value of said word with a new word using the indexer
        Console.WriteLine(sentence[4]);//showing the result of the substition

        Console.WriteLine(SampleInitialization.X);

        Baboon mike = new Baboon { name = "Mike",
                                    similarToHumans=true};
        //created new baboon obj with both the field inherited from animal (name) and the boolean condition of the class.

        string decision;
        if (mike.similarToHumans == true)
        {
            decision = "yes";
        }
        else { decision = "seems impossible"; }
        //creates local variable to send custom response based on the the boolean condition.
            

        Console.WriteLine($" Our lovely Baboon's name is: {mike.name}. Do you think he resembles humans? {decision}");
        //prints out the fields

        Lion john = new Lion { name = "John",
                                   numberOfLegs = 4 };
        //creates new obj that as before extends both field of parent class and lion class
        Console.WriteLine($" This lion is called: {john.name} and he has {john.numberOfLegs} legs!");
        //prints the fields of the obj and class

        Point p1 = new Point(); // p1.x and p1.y will be 0
        Point p2 = new Point(1, 1); // p2.x and p2.y will be 1
        //this is because, considering a struct can't initialize fields, their value will be their default value


        BorderSides leftRight = BorderSides.Left | BorderSides.Right;

        if ((leftRight & BorderSides.Left) != 0)
            Console.WriteLine("Includes Left"); // Includes Left

        string formatted = leftRight.ToString(); // "Left, Right"

        BorderSides s = BorderSides.Left;
        s |= BorderSides.Right;
        Console.WriteLine(s == leftRight); // True
        s ^= BorderSides.Right; // Toggles BorderSides.Right
        Console.WriteLine(s);



        int? sampleNull = null; // OK, nullable type
        Console.WriteLine(sampleNull == null); // True
        //introduction to nullable value type, used before in class definition without knowing it would be faced later
        //value types in itself cannot be null 

        void Food(string? s){
            if (s != null) Console.Write(s.Length);}
        //sample use of null reference forgiving operator in order to avoid a NullReferenceException

        bool[] carson = new bool[] { true, false, true, true, false };
        bool outcome;
        Console.WriteLine("Hi there, pleases select a number from 0 to 4");
        string userImput = Console.ReadLine();
        if (userImput == "0") {
            outcome = carson[0];
            Console.WriteLine($"You entered a {outcome} imput");
        } if (userImput == "1") {
            outcome = carson[1];
            Console.WriteLine($"You entered a {outcome} imput");
                }
        if (userImput == "2"){
            outcome = carson[2];
            Console.WriteLine($"You entered a {outcome} imput");
        }
        else {
            outcome = carson[3];
            Console.WriteLine($"You entered a {outcome} imput");
        }

        /*string sampleCollection = "Samples";
        IEnumerator rator = sampleCollection.GetEnumerator();
        while (rator.MoveNext()) { char c = (char)rator.Current; Console.Write(c + "."); }*/

        
        StringBuilder[] builders = new StringBuilder[5];
        builders[0] = new StringBuilder("builder1");
        builders[1] = new StringBuilder("builder2");
        builders[2] = new StringBuilder("builder3");
        //this array will store value types and therefore each will have its dedicated space in memory

        long[] numbers = new long[3];
        numbers[0] = 12345;
        numbers[1] = 54321;
        //this array will instead store reference types and therefore, depending on the system, each array element will only occupy the space a reference necessitates
        //arrays still always remain reference types because they are a class (<Array>)
        //arrays will therefore always fail an equality test (because this will only check the memory address vaslue they refer to)
        // instead of checking the actual values in the heap (for that, use "structural equality comparer")

        void WriteFirstValue(Array a){
            Console.Write(a.Rank + "-dimensional; ");
            int[] indexers = new int[a.Rank];
            Console.WriteLine("First value is " + a.GetValue(indexers));
        }

        int[] oneD = { 3, 1, 2 };
        int[,] twoD = { { 5, 6 }, { 8, 9 } };

        int[] sampleSortedArray = { 5, 3, 9, 7 };
        string[] sampleDoubleSorting = { "five", "three", "nine", "seven" };

        Console.WriteLine($"these are your unsorted array values: {sampleSortedArray} and {sampleDoubleSorting}");

        WriteFirstValue(oneD); 
        WriteFirstValue(twoD); 
        // whilst the first output will be one, the second output will be 5 - this is becase a two dimensional array, based on thi
        // method will only print the first value itself - not the pair of values

        Array.Sort(oneD);
        Array.Sort(sampleSortedArray);
        //sample sorting method for array - will return oneD containing {1, 2, 3}
        
        Array.Sort(sampleSortedArray, sampleDoubleSorting);
        //sample sorting two arrays (of different type) 
        Console.WriteLine($"this is the value post sorting: {sampleSortedArray} and {sampleDoubleSorting}");


    } // end of <main> class
}
//end of <test> class