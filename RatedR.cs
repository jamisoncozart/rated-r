using System;

class RatedR
{
  static void Main() 
  {
    Console.WriteLine("How old are you?");
    string userAgeString = Console.ReadLine();
    int userAgeNumber = int.Parse(userAgeString);
    Console.WriteLine(userAgeNumber);
  }
}