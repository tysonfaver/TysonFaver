//Dillon Brown, Frankie Pena, Tyson Faver
using System;

class MainClass
{
// this gives us the volume of water in the pipe in gallons
  static double water_amount(double radius, double depth)
  {
  double Inches_depth = depth * 12;

  double pre_water_volume= 3.145*(radius*radius)*Inches_depth;

  double water_volume = pre_water_volume / 23100;

  int Water =(int)Math.Round(water_volume);

  return Water;
  }


   //this tells us how many hours it take to fill up the well using 2 gallons a minute
   static double pipe_water (double water_volume)
   {
  double time_to_fill= (water_volume/2)/60;

  return time_to_fill;
   }



    public static void Main ()
  {
    Console.WriteLine ("Input the radius (in inches) and depth (in feet) of your well");

     double depth = double.Parse(Console.ReadLine());

     double radius = double.Parse(Console.ReadLine());

     double Water = water_amount(radius, depth);

    Console.WriteLine ("Your well holds "+ Water + " gallons of water");

     double time_to_fill = pipe_water (Water);

    Console.WriteLine("this will take "+ time_to_fill + " hours to fill your pipes");

  }
}
