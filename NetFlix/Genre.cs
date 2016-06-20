using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetFlix
{
    public class Genre
    {
        public enum Genra { All, Romance, Action, Comedy }
        public string Name { get; set; }
        private List<Title> _Titles;

        public Genre(Genra Name)                               //CONSTRUCTOR
        {
            this.Name = Name.ToString();
            _Titles = new List<Title>();
        }
        public Genre(string Name)                               //CONSTRUCTOR
        {
            this.Name = Name;
            _Titles = new List<Title>();
        }
        public Genre()                               //CONSTRUCTOR
        {
            this.Name = Name;
            _Titles = new List<Title>();
        }

        public System.Collections.Generic.IEnumerator<Title> GetEnumerator()
        {

            //throw new NotImplementedException();
            foreach (Title item in _Titles)
            {
                yield return (item);
                //yield return default(item);
            }
        }

        public List<Title>  Titles                              // PROPERTY
        {
            get { return _Titles; } // NO "SET". THE LIST HAS "ADD" METHOD FOR EXAMPLE TO DO UPDATING ALREADY
        }
        
        public static Genre operator +(Genre g1, Genre g2)      // + OVERLOAD
        {
            Genre mutGenre = new Genre(g1.Name + " " + g2.Name);
            foreach (Title aTitle in g1.Titles)
            {
                mutGenre.Titles.Add(aTitle);
            }
            foreach (Title aTitle in g1.Titles)
            {
                mutGenre.Titles.Add(aTitle);
            }
            // do I need to copy from g1.titles and g2.titles into mutGenre:
            // I think so. otherwise mutGenre will be empty titles. 
            return mutGenre;         
        }
        public static Genre operator +(Genre g1, Title t1)
        {
            Genre mutGenre = new Genre(g1.Name + " " + t1.Name);
            foreach (Title aTitle in g1.Titles)
            {
                mutGenre.Titles.Add(aTitle);
            }
            mutGenre.Titles.Add(t1);
            return mutGenre;
        }

        // this does not work because at leat one of the operands need to be of the 
        // same type as the Class.
        //Gnew = t1+t1 (not allowed)
        //Gnew = 11 + t1 ( ok )
        //Gnew = t1 + g1 (ok)

        //public static Genre operator +(Title t1, Title t2)      //OVERLOAD
        //{
        //    Genre mutGenre = new Genre(t1.Name + " " + t2.Name);
        //    mutGenre.Titles.Add(t1);
        //    mutGenre.Titles.Add(t2);
        //    return mutGenre;            //return new Title(t1.Name + t2.Name, (t1.Rating + t2.Rating) / 2);
        //}

        // tile iterator....

    }
}