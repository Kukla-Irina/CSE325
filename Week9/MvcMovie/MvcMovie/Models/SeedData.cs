using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = "Adventure",
                    Rating = "PG",
                    Price = 14.99M,
                    ImageName = "heaven.jpg"
                },
                new Movie
                {
                    Title = "The R.M.",
                    ReleaseDate = DateTime.Parse("2003-1-31"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.00M,
                    ImageName = "rm.jpg"
                },
                new Movie
                {
                    Title = "Joseph Smith: Prophet of the Restoration",
                    ReleaseDate = DateTime.Parse("2000-3-24"),
                    Genre = "History",
                    Rating = "NR",
                    Price = 14.00M,
                    ImageName = "joseph.jpg"
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Rating = "PG",
                    Price = 29.99M,
                    ImageName = "meet.jpg"
                }
            );
            context.SaveChanges();
        }
    }
}