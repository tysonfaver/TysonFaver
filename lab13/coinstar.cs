// using System;
// // this will convert imputted coins into cash give back after a 10.9% fee and prints out how many quarters, dimes, nickels, and pennies it was givin
// class CoinStar {
//   static void Main () {
//     int Quarter, Dime, Nickel, Penny, extraCents1, extraCents2, extraCents3, realCents;
//     string inputedCents;
//     double cashVoucher, dollars;
    
//   Console.WriteLine(" Please input total value of change in 1.00 form ");

//     inputedCents = Console.ReadLine();
//      realCents = int.Parse(inputedCents);

//     Quarter = (realCents / 25) ;
//      extraCents1 =  (realCents % 25);
// // This ^^ converts total cents into quarters and then finds how much is left
//     Dime = (extraCents1 / 10) ;
//      extraCents2 =  (extraCents1 % 10);
// // this ^^ converts the rest of the cents into dimes and how much is left
//     Nickel = (extraCents2 / 5) ;
//      extraCents3 =  (extraCents2 % 5);
// // and this ^^ does the same as the others but for nickels
//     Penny = extraCents3;
// // find pennies

//   dollars = (double)realCents;

//     cashVoucher = dollars - (dollars * .109);
// // figures out total returned in cash
//     Console.WriteLine ("You entered " + inputedCents);

//      Console.WriteLine ("That is " + Quarter + " quarters, " + Dime + " dimes, " + Nickel + " nickels " + Penny + " pennies." );

//      Console.WriteLine ("Your total cash back is $" + cashVoucher + " thank you for using CoinStar, come again!");
//   }
// }