﻿using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Player
    {
        //data encapulation create class with the vars for each player 
        public string Name;
        public string College;
        public double Salary;
        public string Position;
        public int Rank;

       //     //getter and setter methods           i believe that these are not needed
       //public void setName(string name)
       // {
       //     //this is a key word that is used for 
       //     this.Name = name;
       //     //could also use name = aname
       // }
       // //this is the get method 
       // public string getName()
       // {
       //     return Name;
       // }
       //  public void setCollege(string college)
       // {
       //     this.College = college;
       // }
       // public string getCollege()
       // {
       //     return College;
       // }
       // public void setSalary(double salary)
       // {
       //     this.Salary = salary;
       // }
       // public double getSalary()
       // {
       //     return Salary;
       // }
       // public void setPosition(string position)
       // {
       //     this.Position = position;
       // }
       // public string getPosition()
       // {
       //     return Position;
       // }
        //defualt contructor
        Player()
        {

        }
        public Player(string name, string college, double salary, int rank, string position)
        {
            Name = name;
            College = college;
            Salary = salary;
            Rank = rank;
            Position = position;
        }
        public override string ToString()
        {
            return String.Format($"RANK:{Rank}\n NAME:{Name}\n College:{College}\n Salary:{Salary.ToString("c")}\n" +
                $"Position: {Position} \n");
            
        }

    }// end player class
}
