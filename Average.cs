using System;

class Average {
   static void computeAverage (double numberOne, double numberTwo, double numberThree)
  {
  double AverageOfNum;

  AverageOfNum = (numberOne + numberTwo + numberThree) / 3 ;


  Console.WriteLine ("The average of your numbers is "+ AverageOfNum) ;
  }



  static void Main ()
 {
 Console.WriteLine ("input three number and it will give you your average");
 double numOne = double.Parse(Console.ReadLine ());
 double numTwo = double.Parse(Console.ReadLine ());
 double numThree = double.Parse(Console.ReadLine ());
  computeAverage (numOne, numTwo, numThree);
}





  }
