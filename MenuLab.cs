using System;

class Menu {
  public static void Main () {
    Console.WriteLine ("welcome to Tiger Meat on our Menu today  we have.");
  int customerOrder;
   string [] Menu_item = new string [4] {null,"Steak and Fries", "Cheeseburger and fries", "Romaine salad"};
   Console.WriteLine("1 " + Menu_item [1]);
   Console.WriteLine("2 " + Menu_item [2]);
   Console.WriteLine("3 " + Menu_item [3]);

  Console.WriteLine ("if you would like to order please enter your desired item's number.");

  customerOrder = int.Parse(Console.ReadLine ());

  Console.WriteLine ("Great Choice! You have ordered the " + Menu_item [customerOrder]);


  }
}
