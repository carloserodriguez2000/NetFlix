using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Show : Title
    {
        private List<Episode> Episodes;
        private List<int> Rating;             // This need implementation as an override from "Title class"

        //string x = "ster";
        public Show()
                {
                 
                }
        public  override string  ToString()        // Need to implement an override for "ToString"
        {
            string rtnStr = Name + Episodes.Count;
            return rtnStr;
        }

        
    }
}