using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS292Final_Kemerly
{
    class Globals
    {
        //global stuff

        /*decisionStage -
         * 0:fresh, 1:categories endorsed, 2: category selected
         * 3:names endorsed 4:final     */

        public static int gDecisionStage = 0;
        public static List<CatStruct> gCatList = new List<CatStruct>();
        public static List<string> gCatDecisionList = new List<string>();
        public static List<RestStruct> gRestList = new List<RestStruct>();
        public static List<string> gRestDecisionList = new List<string>();
        public static string gSelectedCategory = "";

        public struct CatStruct//"Category Structure"
        {
            public string category;
            public double weight;
        }

        public struct RestStruct//"Restaurant Structure"
        {
            public string name;
            public double weight;
        }

    }
}
