using System;

class RatedR
{
  static bool checkIfOlderThan17(int age)
  {
    if(age >= 17)
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  static void Main() 
  {
    Console.WriteLine("How old are you?");
    string userAgeString = Console.ReadLine();
    int userAgeNumber = int.Parse(userAgeString);
    if(checkIfOlderThan17(userAgeNumber))
    {
      Console.WriteLine("You are old enough to see this movie");
    }
    else
    {
      Console.WriteLine("I'm sorry, you are NOT old enough to see this movie");
    }
  }
}