using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWalker_Lab3
{
    public class State
    {
        //create a state class and include all properties
        public int StateID { get; set; }
        public string StateName { get; set; }
        public string Population {  get; set; }
        public string StateFlag { get; set; }
        public string StateFlower { get; set; }
        public string StateBird { get; set; }
        public string StateColors { get; set; }
        public string LargestCities { get; set; }
        public string StateCapitol { get; set; }
        public string MedianIncome { get;set; }
        public string ComputerJobs { get; set; }

        //I had the numeric properties set to int or float, but it kept throwing errors when I tried to cast it so I had to end up changing them all to string. I'm not sure why it wasn't working right. But should be fine since we're not doing any calculations with the data right now.

        //constructor
        public State(int stateID, string stateName, string population, string stateFlag, string stateFlower, string stateBird, string stateColors, string largestCities, string stateCapitol, string medianIncome, string computerJobs)
        {
            StateID = stateID;
            StateName = stateName;
            Population = population;
            StateFlag = stateFlag;
            StateFlower = stateFlower;
            StateBird = stateBird;
            StateColors = stateColors;
            LargestCities = largestCities;
            StateCapitol = stateCapitol;
            MedianIncome = medianIncome;
            ComputerJobs = computerJobs;
        }
    }

    
}