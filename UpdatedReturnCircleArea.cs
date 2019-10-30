using System;

class circleArea {
   static double circleMath (double radius)
  {
  double areaOfCircle;

  areaOfCircle = 3.14159 * (radius * radius);


  return areaOfCircle;
  }



  static void Main ()
 {
 Console.WriteLine ("What is the radius of your cirle?");
 double radius = double.Parse(Console.ReadLine ());

  double areaOfCircleAnswer = circleMath (radius);

Console.WriteLine ("Area of your circle is "+ areaOfCircleAnswer) ;

 }





  }
