using System;
using System.Collections.Generic;
using System.Linq;

namespace project1
{
    class Program
        {
        //need to create a class so i can make the objects of players
        //use a bool value once the a player is selected so they user can use it twice
        

        static void Main(string[] args)

        {   //deculartions 
            string primer,sential="EXIT";
            double Budget = 95000000;
            double costSelected;
            double moneyLeft;
            string playerNameSelection;
            double deal = 65000000;

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
            Console.WriteLine("Welcome to the NFL Draft Program");
            Console.WriteLine("Please type Enter to get started");
            Console.WriteLine($"Please select up to 5 players and you have a budget of {Budget.ToString("c")} ");
            primer=Console.ReadLine();
            while (primer != sential)
            {
               
                Player[] player = new Player[40];
                List<Player> PlayerList = new List<Player>();
                List<Player> selectionList = new List<Player>(5);
                //int y = 0;

                //creating the object for Joe Burrow 
                for (var x = 0; x < playersName.GetLength(0); x++)

                {
                    for (var y = 0; y < playersName.GetLength(1); y++)
                    {
                        //Console.WriteLine(playersName[x,y]);
                        //Console.WriteLine(playersCollege[x, y]);
                        //Console.WriteLine(playersCost[x, y].ToString("c"));
                        //Console.WriteLine(rank[x,y]);
                        //Console.WriteLine(Position[x,y]);
                        //Console.WriteLine(player[x]);

                        //Player player;
                        //x++;
                        player[x]  = new Player(playersName[x, y], playersCollege[x, y], playersCost[x, y], rank[x, y], Position[x, y]);
                        //Console.WriteLine(player[x]);
                        PlayerList.Add(player[x]);
                        //Console.WriteLine("output player list");
                        //Console.WriteLine(PlayerList);

                    } //inner for loop y
                }// end of the for loop X
                //out put the list 
                Console.WriteLine("checking to see if the list is outputing");
                PlayerList.ForEach(x => Console.WriteLine(x.ToString()));
                    



                for (var s=0 /*selectionList.Count*/; s <=4 ; s++)
                {
                    Console.WriteLine($"you have picked {s} Players");
                   Console.WriteLine($"please enter the player name for pick {s+1}");
                    Console.WriteLine("Press 'enter' if you are done selecting players");
                    playerNameSelection = Console.ReadLine();
                  if (playerNameSelection == "")
                    {
                        break;
                    }
                    for (var i = PlayerList.Count - 1; i >= 0; i--)
                        //(var i =0; PlayerList.Count > i;  i++)
                    { 
                        if (PlayerList[i].Name.Contains(playerNameSelection))
                        {
                            selectionList.Add(PlayerList[i]);
                            PlayerList.RemoveAt(i);
                        }
                        
                        //if(!(PlayerList[i].Name.Contains(playerNameSelection)))
                        //{
                        //    Console.WriteLine("Please check Spelling and enter correct player name!!!");
                            
                        //}
                    }

                    PlayerList.ForEach(x => Console.WriteLine(x.ToString()));

                    Console.WriteLine("SELECTED PLAYERS_BELOW_______REMAINING_CHOICES_ABOVE____________________________");
                    selectionList.ForEach(x => Console.WriteLine(x.ToString()));
                     //get the total of players selected and the remaining budget left 
                    costSelected =selectionList.Sum(item => item.Salary);
                    moneyLeft = costSelected - Budget;
                    if (costSelected > Budget)
                    {
                        Console.WriteLine("You have exceeded the budget and must start over");
                        break;
                    }
                    Console.WriteLine($"You have spent {costSelected.ToString("c")}");
                    Console.WriteLine($"You have {moneyLeft.ToString("c")} remaining");

                    //cost effective check if top three players and not working for this 
                    //if (selectionList.Exists(x => x.Rank == 1) || selectionList.Exists(x => x.Rank == 2) || selectionList.Exists(x => x.Rank == 3)
                    //    && /*costSelected =*/ selectionList.Sum(item => item.Salary) < deal) 
                    //{
                    //    Console.WriteLine("1111111111COngrats you are cost effective");
                    //}
            }
                costSelected = selectionList.Sum(item => item.Salary);
                if ((selectionList.Exists(x => x.Rank == 1) || selectionList.Exists(x => x.Rank == 2) || selectionList.Exists(x => x.Rank == 3))
                      && costSelected /*= selectionList.Sum(item => item.Salary)*/ < deal)
                {
                    Console.WriteLine("Congrats you are cost effective");
                }




                //Console.WriteLine(player[3]);
                //Player QBone = new Player();
                //QBone.setName("Joe Burrow");
                //QBone.setCollege("LSU");
                //QBone.setSalary(26000000);
                //QBone.setPosition("Quarter Back");

                //Console.WriteLine($"Name:{ QBone.Name}");

                //christian.Greeting();
                //christian.bio();
                Console.WriteLine("please press enter to run program again or type'EXIT' to end program ");
                primer= Console.ReadLine().ToUpper();
            }//end of while loop primer
        }//end  of the main 
    }// end of the class program 
}
