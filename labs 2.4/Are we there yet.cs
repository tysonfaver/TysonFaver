using System;

class AreWeThereYet {
  public static void Main () {
    Console.WriteLine ("Enter a childs age.");
  int i;
  int childsAge = int.Parse(Console.ReadLine());

  for ( i = 0 ; i < childsAge ; i = i + 1 )        {    Console.WriteLine ( "Are we there yet?" ) ;   }

  }
}
