using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Title
    {
        //public int RatingType { NR, PG, PG13, G, R, Adult, XXX };
        //RatingType Rating;
        int Rating;
        public string Name { get; set; }
        //public string Rating;   // change this to a property

        public Title(string Name, int Rating)
        {
            this.Name = Name;
            this.Rating = Rating;
        }
        public Title()
        {
            this.Name = null;
            this.Rating = 0;    // null not posible this way.
        }

        public static Title operator +(Title t1, Title t2)
        {
            // return new Title( t1.name + t2.name, t1.rating +t2.rating)
            return new Title();
            //return new Title("summed names", t1.Rating.ToString()+t2.Rating.ToString());         // not correct. need to return a "Aggregated Genre"
                                                                        // ned to figure this out.
        }
    }//END OF CLASS
}//END OF NAMESPACE