// Single-line comment

/* Multi-line 
   comment */

// Data Types

// int intNum = 9;
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

class IthinkThisCanBeCalledAnything {
  // main method
  static void Main(string[] args)
  {

    string first = "Lorem";
    string last = "Ipsum";

    // string concatenation
    string name = first + " " + last;
    Console.WriteLine(name); // => Lorem Ipsum

    // sting interpolation
    string nameInterpolated = $"{first} {last}";
    Console.WriteLine(nameInterpolated);
  }
}
