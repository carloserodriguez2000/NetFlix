using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Genre
    {
        public string Name { get; set; }
        private List<Title> Titles;
        
        public Genre(string Name)
        {
            this.Name = Name;
        }

        
        public static Genre operator +(Genre g1, Genre g2)
        {
            // return new Title( t1.name + t2.name, t1.rating +t2.rating)
            return new Genre(g1.Name + " " + g2.Name);         // not correct. need to return a "Aggregated Genre"
                                                                        // ned to figure this out.
        }
        public static Genre operator +(Genre g1, Title t2)
        {
            // return new Title( t1.name + t2.name, t1.rating +t2.rating)
            return new Genre(g1.Name + " " + t2.Name);         // not correct. need to return a "Aggregated Genre "
                                        // ned to figure this out.
        }

        // tile iterator....

    }
}