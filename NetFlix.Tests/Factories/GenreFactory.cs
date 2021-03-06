using NetFlix;
using System;
using Microsoft.Pex.Framework;

namespace NetFlix
{
    /// <summary>A factory for NetFlix.Genre instances</summary>
    public static partial class GenreFactory
    {
        /// <summary>A factory for NetFlix.Genre instances</summary>
        [PexFactoryMethod(typeof(Genre))]
        public static Genre Create(string Name_s)
        {
            Genre genre = new Genre(Name_s);
            return genre;

            // TODO: Edit factory method of Genre
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
