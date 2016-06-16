using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Movie : Title
    {
        private int Duration;

        public override string ToString()        // Need to implement an override for "ToString"
        {
            string rtnStr = Name + Duration.ToString();
            return rtnStr;
        }

    }
}