using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Show : Title
    {
        private List<Episode> _Episodes;

        public Show()   //CONSTRUCTOR
        {
            _Episodes = new List<Episode>();
        }

        public List<Episode> Episodes
        {
            get { return _Episodes; }
        }

        public new int Rating
        {
            get
            {
                return rtnEpisodesAvg();        // ignore this comment return base.Rating;
            }
        }

        private int rtnEpisodesAvg()
        {
            int sumation=0;
            foreach (Episode item in _Episodes)     // investigate how to override the build-in method "List.Average".
                sumation += item.Rating;

            return (sumation / _Episodes.Count);
        }
        public override string ToString()        // Need to implement an override for "ToString"
        {
            return  (Name +" " + "has "+ _Episodes.Count + " episodes");   
         }
    }
}