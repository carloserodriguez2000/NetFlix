using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Title
    {
        private int? _rating;
        public string Name { get; set; }

        public int? Rating                                      //PROPERTY
        {
            get { return _rating;  }
            set { _rating = value; }
        }

        public Title(string Name, int? Rating)                   //CONSTRUCTOR
        {
            this.Name = Name;
            this.Rating = Rating;
        }
        public Title()                                          //CONSTRUCTOR
        {
            Name = null;
            Rating = null;    // null not posible this way.
        }

        public static Genre operator +(Title t1, Title t2)      //OVERLOAD
        {
            //string mutName = t1.Name + " " + t2.Name;       // needs to return a combined GENRE. 
            Genre mutGenre = new Genre(t1.Name + " " + t2.Name);
            mutGenre.Titles.Add(t1);
            mutGenre.Titles.Add(t2);
            return mutGenre;            //return new Title(t1.Name + t2.Name, (t1.Rating + t2.Rating) / 2);
        }
    }//END OF CLASS
}//END OF NAMESPACE