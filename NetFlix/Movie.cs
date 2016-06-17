using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Movie : Title
    {
        public int Duration { get; }

        public override string ToString()        // Need to implement an override for "ToString"
        {
          return  (Name + Duration.ToString());
        }
    }
}