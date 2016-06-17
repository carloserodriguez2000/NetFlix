using NetFlix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFlix
{
    class Program
    {
        static void Main(string[] args)
        {
            Genre RomaticGenre = new Genre(Genre.Genra.Romance.ToString());
            Genre ActionGenre = new Genre(Genre.Genra.Action.ToString());
            Genre ComedyGenre = new Genre(Genre.Genra.Comedy.ToString());

            ////////////////////        MOVIES
            RomaticGenre.Titles.Add(new Movie() { Name = "When Harry Met Sally",Rating = 5});
            RomaticGenre.Titles.Add(new Movie() { Name = "31 Weddings", Rating = 4 });
            ////////////////////
            ActionGenre.Titles.Add((Title)new Movie() { Name = "Dirty Harry", Rating = 5 });
            ActionGenre.Titles.Add((Title)new Movie() { Name = "Fast and Furious", Rating = 5 });
            ///////////////////
            ComedyGenre.Titles.Add((Title)new Movie() { Name = "Anchor Man", Rating = 5 });
            ComedyGenre.Titles.Add((Title)new Movie() { Name = "Borat", Rating = 4 });
            ///////////////////////////////////////////////

            
            /////////////// SHOWS      
            //ActionGenre.Titles.Add((Title)new Show() { Name = "Game Of Thrones", Rating = 5 }) ;
           // Show showadd = new Show() { Name = "Game Of Thrones", Rating = 5 };
            Show showadd = new Show() { Name = "Game Of Thrones" };

            showadd.Episodes.Add(new Episode() { name = "Battle of noting", Rating = 3 });
            showadd.Episodes.Add(new Episode() { name = "Battle for the Hottie", Rating = 5 });
            showadd.Episodes.Add(new Episode() { name = "Battle for the Nerd", Rating = 1 });
            ActionGenre.Titles.Add((Title)showadd);

            Show ashow = (Show)ActionGenre.Titles.Last();   // this works but need to figure out how to do on easily by using "name" for example
            Console.WriteLine(ashow.Rating);

            ///////////////////////////////////////////////
            ActionGenre.Titles.Add((Title)new Movie() { Name = "Casper", Rating = 5 });
           

            Console.Read();

        }
    }
}
