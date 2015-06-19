using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Skill : IPurchasable
    {
        public int BaseCost { get; set; }
        public string Name { get; set; }
        public List<Equipment> Benefits { get; set; }

        public string TierName { get; set; }

        public int LevelsForPoints(int points)
        {
            int level;
            var costSoFar=0;
            for (level = 1; level < 14; level++)
            {
                costSoFar += BaseCost*level;
                if (costSoFar < points) continue;
                
                level--;
                break;
            }
            return level;
        }

        public int PointsForLevel(int level)
        {
            var costSoFar = 0;
            for (var i = 1; i < level; i++)
            {
                costSoFar += BaseCost * level;
            }
            return costSoFar;
        }
    }
}
