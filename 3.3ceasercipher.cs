using System;

class Program
{

    static string encrypt(string value, int shift)
    {
        char[] buffer = value.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            letter = (char)(letter + shift);

            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }

            buffer[i] = letter;
        }
        return new string(buffer);
    }

  static string decrypt(string value, int shift)
    {
        char[] buffer = value.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {

            char letter = buffer[i];

            letter = (char)(letter - shift);

            if (letter > 'z')
            {
                letter = (char)(letter - 26);
            }
            else if (letter < 'a')
            {
                letter = (char)(letter + 26);
            }

            buffer[i] = letter;
        }
        return new string(buffer);
    }







    static void Main()
    {
      string functionUse;

       Console.WriteLine("would you like to encrypt or decrypt?");

      functionUse = Console.ReadLine();

       if (functionUse == "encrypt"){
         Console.WriteLine ("please input your phrase and the number shift (up to 25)  to encrypt (no spaces)");

       string phrase = Console.ReadLine();
         int shiftNum = int.Parse(Console.ReadLine());
        string encryptedPhrase = encrypt(phrase, shiftNum);
          Console.WriteLine(encryptedPhrase);
       }

        if (functionUse == "decrypt"){
         Console.WriteLine ("please input your encrypted phrase and its shift to decrypt (no spaces)");

       string phrase = Console.ReadLine();
        int shiftNum = int.Parse(Console.ReadLine());
        string decryptedPhrase = decrypt(phrase, shiftNum);
          Console.WriteLine(decryptedPhrase);
        }






    }
}
