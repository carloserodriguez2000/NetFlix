using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    class View
    {
        public View()
        {
            // nothing to construct yet
        }
        public void Display(Genre aGenre)
        {
            Console.WriteLine("|-------------------------------------------");
            Console.WriteLine("|-------------" + aGenre.Name + "-----------");
            //foreach (Title item in aGenre) this wont work until GetEnumerator is implemented
            foreach (var item in aGenre)
         //            foreach (Title item in aGenre.Titles)
            {
                if (item.GetType() == typeof(Movie))
                {
                    Console.Write(    "| " + item); // Print name and duration due to override
                    Console.WriteLine();
                }
                if( item.GetType() == typeof(Show))
                {
                    Show aShow = (Show)item;
                    Console.WriteLine("| " + aShow.ToString()); // Print name and number of episodes
                    foreach (Episode anEpisode in aShow.Episodes)
                    {
                        Console.WriteLine("|   -" + anEpisode.name + " Rating:" + anEpisode.Rating);
                    }
                }
            }
            Console.WriteLine("|-------------------------------------------");

        }// END OF DISPLAY METHOD
    }// END OF class
}// END OF NAMESPACE
