using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string name;
        public int score;
        public int choice;
        public virtual void GetName()
        {
        }
        public virtual void MakeChoice()
        {
        }
        public int GetScore()
        {
            return score;
        }
        public int AddPoint()
        {
            score ++;
            return score;
        }
    }
}
