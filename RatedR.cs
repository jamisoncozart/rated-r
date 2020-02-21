using System;

class RatedR
{
  static void Main() 
  {
    Console.WriteLine("How old are you?");
    string userAgeString = Console.ReadLine();
    int userAgeNumber = int.Parse(userAgeString);
    if(userAgeNumber >= 17)
    {
      Console.WriteLine("You are old enough to see this movie");
    }
    else
    {
      Console.WriteLine("I'm sorry, you are NOT old enough to see this movie");
    }
  }
}