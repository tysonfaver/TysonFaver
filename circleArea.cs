using System;

class circleArea {
   static void circleMath (double radius)
  {
  double Areaofcircle;

  Areaofcircle = 3.14159 * (radius * radius);


  Console.WriteLine ("Area of your circle is "+ Areaofcircle) ;
  }



  static void Main ()
 {
 Console.WriteLine ("What is the radius of your cirle?");
 double radius = double.Parse(Console.ReadLine ());

  circleMath (radius);



 }





  }
