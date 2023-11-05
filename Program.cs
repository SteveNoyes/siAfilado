// Single-line comment

/* Multi-line 
   comment */

// Data Types

// int intNum = 9;                    Integer value
// long longNum = 9999999;            64 bit signed integer
// float floatNum = 9.99F;            Floating point number
// double doubleNum = 99.999;         64-bit floating-point
// decimal decimalNum = 99.9999M;     High precision decimal numbers
// char letter = 'D';                 16 bit Unicode character
// bool @bool = true;                 True or false boolean value
// string site = "quickref.me";       Set of characters

// Variables not implicitly defined


// var num = 999;
// var str = "999";
// var bo = false;

class AskForUserInput {
  // main method
  static void Main(string[] args)
  {

    string first = "To sign up for our newsletter";
    string second = "fill out the large form on the next page";
    string last = "and we'll send you a ton of feedback, all the time";
    string nonRelease = "what unsubscribe button";

    // string concatenation
    string name = first + " " + second;
    Console.WriteLine(name);

    // sting interpolation
    string nameInterpolated = $"{last} {nonRelease}";
    Console.WriteLine(nameInterpolated);

    Console.WriteLine("Please enter a number to reach you at:");
    if(int.TryParse(Console.ReadLine(),out int input))
    {
      // Input validated
      Console.WriteLine($"You entered {input}");
    }
  }

}
