using System;

namespace project1
{
    class Program
        {
        //need to create a class so i can make the objects of players
        //use a bool value once the a player is selected so they user can use it twice
        

        static void Main(string[] args)

        {
            string[,] playersName = 
                {
                { "Joe Burrow ", "Tua Tagoviloa","Justin Herbert","Jordan Love","Jake Fromm"},
                { "D'Andre Swift", "Jonathan Taylor","J.K Dobbins","Zack Moss","Cam Akers"},
                { "CeeDee Lamb ", "Jerry Jeudy","Tee Higgins","Henry Ruggs III","Yeter Gross-Matos"},
                { "Chase Young ", "Derrick Brown","A.J Epenesa","Javon Kinlaw","Yeter Gross-Matos"},
                { "Jeff Okudah", "Grant Delpit","Kristian Fulton","Xavier McKinny","CJ Jenderson"},
                { "Cole Kmet", "Brycen Hopkins","Hunter Bryant","Jared Pinkney","Jacob Breeland"},
                { "Isaiah Simmons", "Kenneth Murray","Zach Baun","Akeem Davis-Gaither","Troy Dye"},
                { "Jedrick Wills Jr.", "Andrew Thomas","Tristan Wirfs","Tyler Biadasz","Mekhi Becton"}
                };

            string[,] playersCollege =
                {
                { "(LSU) ", "(Alabama)","(Oregon)","(Utah St.)","(Georgia)"},
                { "(Gerogia)", "(Wisconsin)","(Ohio St.)","(Utah)","(Florida St.)"},
                { "(Oklahoma)", "(Alabama)","(Clemson)","(Alabama)","(Minnesota)"},
                { "(Ohio St.)", "(Auburn)","(Iowa)","(So. Carolina)","(Penn St.)"},
                { "(Ohio St.)", "(LSU)","(LSU)","(Alabama)","(Florida)"},
                { "(Norte Dame)", "(Purdue)","(Washington)","(Vanderbilt)","(Oregon)"},
                { "(Clemson)", "(Oklahoma)","(Wisconsin)","(App. St.)","(Oregon)"},
                { "(Alabama)", "(Geogia)","(Iowa)","(Wisconsin)","(Louisville)"}
                };

            double [,] playersCost =
                {
                {26400100,20300100,17420300,13100145,10300000},
                {24500100,19890200,18700800,15000000,11600400},
                {23400000,21900300,19300230,13400230,10000000},
                {26200300,22000000,16000000,18000000,13000000},
                { 24000000,22500249,20000100,16000200,11899999},
                { 27800900,21000800,17499233,27900200,14900333},
                { 22900300,19000590,18000222,12999999,10000100},
                { 23000000, 20000000,19400000,16200700,15900000}
                };
            int[,] rank=
                {
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                {1,2,3,4,5 },
                 };
            string [,] Position=
            {
                {"Quarterback","Quarterback","Quarterback","Quarterback","Quarterback" },
                {"Running Back","Running Back","Running Back","Running Back","Running Back" },
                {"Wide-Receiver","Wide-Receiver","Wide-Receiver","Wide-Receiver","Wide-Receiver" },
                {"Defensive Lineman","Defensive Lineman","Defensive Lineman","Defensive Lineman","Defensive Lineman" },
                {"Defensive-Back","Defensive-Back","Defensive-Back","Defensive-Back","Defensive-Back" },
                {"Tight End","Tight End","Tight End","Tight End","Tight End" },
                {"Line-Backer","Line-Backer","Line-Backer","Line-Backer","Line-Backer" },
                {"Offensive Tackle","Offensive Tackle","Offensive Tackle","Offensive Tackle","Offensive Tackle" },
            }; 

                 Player[] player = new Player[40];
            //int y = 0;
            Console.WriteLine("checking commit to repo");
            //creating the object for Joe Burrow 
            for (var x = 0; x < playersName.GetLength(0); x++)
                
            {
             for (var y = 0;y< playersName.GetLength(1); y++ )
                {
                //Console.WriteLine(playersName[x,y]);
                //Console.WriteLine(playersCollege[x, y]);
                //Console.WriteLine(playersCost[x, y].ToString("c"));
                //Console.WriteLine(rank[x,y]);
                //Console.WriteLine(Position[x,y]);
                //Console.WriteLine(player[x]);

                    
                //Player player;
                    //x++;
                player [x]= new Player(playersName[x,y],playersCollege[x,y],playersCost[x,y],rank[x,y],Position[x,y]);
                    Console.WriteLine(player[x]);
                    
                } //inner for loop y
            }// end of the for loop X
            //Console.WriteLine(player[3]);
            //Player QBone = new Player();
            //QBone.setName("Joe Burrow");
            //QBone.setCollege("LSU");
            //QBone.setSalary(26000000);
            //QBone.setPosition("Quarter Back");

            //Console.WriteLine($"Name:{ QBone.Name}");

            //christian.Greeting();
            //christian.bio();
        }
    }// end of the class program 
}
