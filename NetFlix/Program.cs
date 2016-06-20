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
            List<Genre> AllGenres ;

            //Genre RomaticGenre = new Genre() { Name = "Romance" };
            //Genre RomaticGenre = new Genre() { Name = Genre.Genra.Romance.ToString() };
            //Genre RomaticGenre  = new Genre(Genre.Genra.Romance.ToString()) { Name = "Romantic" };
            Genre RomaticGenre = new Genre(Genre.Genra.Romance);
            Genre ActionGenre   = new Genre(Genre.Genra.Action);
            Genre ComedyGenre   = new Genre(Genre.Genra.Comedy);
            
            ////////////////////        MOVIE      //////////////////////////////////////////
            RomaticGenre.Titles.Add(new Movie() { Name = "When Harry Met Sally",Rating = 5});
            RomaticGenre.Titles.Add(new Movie() { Name = "31 Weddings", Rating = 4 });
            ////////////////////
            ActionGenre.Titles.Add((Title)new Movie() { Name = "Dirty Harry", Rating = 5 });
            ActionGenre.Titles.Add((Title)new Movie() { Name = "Fast and Furious", Rating = 5 });
            ///////////////////
            ComedyGenre.Titles.Add((Title)new Movie() { Name = "Anchor Man", Rating = 5 });
            ComedyGenre.Titles.Add((Title)new Movie() { Name = "Borat", Rating = 4 });
            ////////////////////////////////////////////////////////////////////////////////

            
            /////////////// SHOWS ///////////////////// 
            //ActionGenre.Titles.Add((Title)new Show() { Name = "Game Of Thrones", Rating = 5 }) ; RATING SHOW BE AN AGGREGATE OF ALL THE EPISODES POSSIBLY???
            Show showToAdd = new Show() { Name = "Game Of Thrones" };                               //BUILD SHOW
                    //ADD EPISODES TO THE SHOW //
            showToAdd.Episodes.Add(new Episode() { name = "Battle of noting", Rating = 3 });        //ADD EPISODE TO SHOW
            showToAdd.Episodes.Add(new Episode() { name = "Battle for the Hottie", Rating = 5 });   //ADD EPISODE TO SHOW
            showToAdd.Episodes.Add(new Episode() { name = "Battle for the Nerd", Rating = 1 });     //ADD EPISODE TO SHOW
            ActionGenre.Titles.Add((Title)showToAdd);


            /////////////////////////  GET THE AGGREGATED RATINGS ////////////////////
            Show ashow = (Show)ActionGenre.Titles.Last();   // this works but need to figure out how to do on easily by using "name" for example
            Console.WriteLine(ashow.Rating);
            /////////////////////////////////////////////////////////////////////////

            ///////////////////////// ADD ANOTHER MOVIE /////////////////////////////
            ActionGenre.Titles.Add((Title)new Movie() { Name = "Casper", Rating = 5 });
            ////////////////////////////////////////////////////////////////////////

            //////////////////// ADD TWO TITLES AND GET A COMBINED GENRE ////////////
            Movie movie1 = new Movie() { Name = "Iron Man", Rating = 5 };
            Movie movie2 = new Movie() { Name = "American Gigolo", Rating = 5 };
            Genre ComboTitleTitle = movie1 + movie2;
            ////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////
            Genre ComboGenreTitle = RomaticGenre + movie1;
            ////////////////////////////////////////////////////////////////////////


            /////////////////////////////////////////////////////////////////////////
            // two ways to implement the "All Genre".  
            // 1-) Have a new instance of Genre and copy rererences of all the titles in all the other Genres.
            // 2-) Have a local List that contains all the Genres.
            // Genre AllGenres      = new Genre(Genre.Genra.Comedy.ToString()) { Name = "All" };
            //Then copy references off all the Genres instatiated above.

            ///////////////// All Genres method-2 ////////////////////////
            AllGenres = new List<Genre>();
            AllGenres.Add(RomaticGenre);
            AllGenres.Add(ActionGenre);
            AllGenres.Add(ComedyGenre);
            /////////////////////////////////////////////////////////////


            ////////////////////////LETS DISPLAY THE CONTENT//////////////////
            View LetsView = new View();

            LetsView.Display(ActionGenre);
            LetsView.Display(RomaticGenre);
            LetsView.Display(ComedyGenre);
            LetsView.Display(ComboTitleTitle);
            LetsView.Display(ComboGenreTitle);
            //////////////////////////////////////////////////////////////////

            Console.Read();

        }
    }
}
