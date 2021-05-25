using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovieIdentity.Data;
using MvcMovieIdentity.Models;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        ImageUrl = "/img/default.jpg",
                        Title = "Casablanca",
                        ReleaseYear = 1942,
                        GenreId = 2
                    },

                    new Movie
                    {
                        ImageUrl = "/img/default.jpg",
                        Title = "Star Wars: Episode III - Revenge of the Sith",
                        ReleaseYear = 2005,
                        GenreId = 3
                    },

                    new Movie
                    {
                        ImageUrl = "/img/default.jpg",
                        Title = "Scent of a Woman",
                        ReleaseYear = 1992,
                        GenreId = 2
                    },

                    new Movie
                    {
                        ImageUrl = "/img/default.jpg",
                        Title = "The Shining",
                        ReleaseYear = 1980,
                        GenreId = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}