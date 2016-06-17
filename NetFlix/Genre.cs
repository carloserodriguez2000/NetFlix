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
        
        public Genre(string Name)   //CONSTRUCTOR
        {
            this.Name = Name;
            _Titles = new List<Title>();
        }

        public List<Title>  Titles
        {
            get { return _Titles; } // NO "SET". THE LIST HAS "ADD" METHOD FOR EXAMPLE TO DO UPDATING ALREADY
        }
        
        public static Genre operator +(Genre g1, Genre g2)
        {
            Genre mutGenre = new Genre(g1.Name + " " + g2.Name);
            // do I need to copy from g1.titles and g2.titles into mutGenre:
            // I think so. otherwise mutGenre will be empty titles. 
            return mutGenre;         
        }
        public static Genre operator +(Genre g1, Title t2)
        {
            g1.Titles.Add(t2);
            return g1;
        }

        // tile iterator....

    }
}