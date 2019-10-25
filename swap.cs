using System;

class Swapper {
   static void Swap (double numOne, double numTwo)
  {

  Console.WriteLine ("Before: "+ numOne + " , " + numTwo) ;
  Console.WriteLine ("After: " + numTwo + " , " + numOne) ;
  }



  static void Main ()
 {
 Console.WriteLine ("input two numbers and watch what happens");
 double tempNum1 = double.Parse(Console.ReadLine ());
 double TempNum2 = double.Parse(Console.ReadLine ());
  Swap (tempNum1, TempNum2);
}





  }
