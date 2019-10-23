using System;

class howManyEggs {
   static void computeEggs (int boxes)
  {
  int eggs;

  eggs = boxes * 12;


  Console.WriteLine ( "You have " + eggs + " Eggs" + " in your " + boxes + " dozen eggs") ;
  }



  static void Main ()
 {
 Console.WriteLine ("How many dozens of eggs do you have?");
 int dozens = int.Parse(Console.ReadLine ());

  computeEggs (dozens);



 }





  }
