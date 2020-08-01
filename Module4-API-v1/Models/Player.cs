using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Module4_API_v1.Models
{
    [Serializable]
    public class Player
    {
        //beginning of re-structure for PoT game-menu
        //to integrate with an api for data-stream from Game-Scenes to the data stores
        public int PlayerID {get; set;}
        public string PlayerName { get; set; }
        public int Xp;
        public int Points;
        public bool Alive;

        //default constructor
        public Player() { }

        //re-evaulate the xp-mechanism to work with Scene object:
        public int LvlUp()
        {
            if (Points > 10)
            {
                return this.Xp + 1;
            }

            if (Points <= 10)
            {
                return this.Xp;
            }
            else return this.Points;
        }

        public override string ToString()
        {
            return "Id: " + PlayerID + " Name: " + PlayerName;
        }

    }

    public class Game : Player
    {
        //object to return values in runtime
        public Game InScene;

        //values to record Active scene
        public DateTime BeginPlay;
        public DateTime EndPlay;
        //scene end:
        public bool Killed;

        //for game-events:
        public string EventName;
        public string EventDescription;

        //default constructor:
        public Game() { }

        //to test with Api: (Read, Train, Hack) for BillG's environ
        public Game(string eName, string eDescription)
        {
            EventName = eName;
            EventDescription = eDescription;
        }
    }
}