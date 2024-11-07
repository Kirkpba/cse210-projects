using System;
//Main Program class Code.
class Program
{
  static void Main(string[] args)
  {
    //Starts the Mindfulness Class to display the menu and will
    //call each class to perform it's respected activity. 
    MindfulnessApp app = new MindfulnessApp();
    app.StartApp();
  }
}