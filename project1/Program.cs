using System;

namespace project1
{
    class Program

        //need to create a class so i can make the objects of players
        //use a bool value once the a player is selected so they user can use it twice
    {
        static void Main(string[] args)

        {
            Console.WriteLine("checking commit to repo");
            //creating the object for Joe Burrow 
            Player QBone = new Player();
            QBone.setName("Joe Burrow");
            QBone.setCollege("LSU");
            QBone.setSalary(26000000);
            QBone.setPosition("Quarter Back");

            Console.WriteLine($"Name:{ QBone.Name}");

            //christian.Greeting();
            //christian.bio();
        }
    }// end of the class program 
}
