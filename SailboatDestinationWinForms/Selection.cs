using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SailboatDestinationWinForms
{
    class Selection
    {
        private int crewSize;
        private String difficulty;
        private String cruiseType;
        private String budget;

        public Selection (int t_crewSize, String t_difficulty, String t_type, String t_budget)
        {
            this.crewSize = t_crewSize;
            this.difficulty = t_difficulty;
            this.cruiseType = t_type;
            this.budget = t_budget;
        }

        public int GetCrewSize()
        {
            return this.crewSize;
        }

        public string GetDifficulty()
        {
            return this.difficulty;
        }

        public string GetCruiseType()
        {
            return this.cruiseType;
        }
        public string GetBudget()
        {
            return this.budget;
        }

        public String MsgBoxMsg()
        {
           String returnedMsg = Environment.NewLine + "Crew size: " + this.crewSize + Environment.NewLine + "Difficulty: " + this.difficulty + Environment.NewLine + "Budget: " + this.budget + Environment.NewLine + "Cruise type: " + this.cruiseType;
            return returnedMsg;
        }
    }
}
