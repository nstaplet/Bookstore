using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            BookstoreDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookstoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        Author = "Victor Hugo",
                        Publisher = "Signet",
                        ISBN = "987-0451419439",
                        Category = "Fiction, Classic",
                        Price = (int)9.95,
                        NumberOfPages = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        Author = "Doris Kearns Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Category = "Non-Fiction, Biography",
                        Price = (int)14.58,
                        NumberOfPages = 944
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        Author = "Alice Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Category = "Non-Fiction, Biography",
                        Price = (int)21.54,
                        NumberOfPages = 832
                    },

                    new Book
                    {
                        Title = "The Way of Kings",
                        Author = "Brandon Sanderson",
                        Publisher = "Tor Books",
                        ISBN = "978-0765326355",
                        Category = "Fantasy",
                        Price = (int)9.59,
                        NumberOfPages = 1007
                    },

                    new Book
                    {
                        Title = "Return of the King",
                        Author = "J.R.R. Tolkein",
                        Publisher = "Melbourne University Publishing",
                        ISBN = "978-0618260553",
                        Category = "Fantasy",
                        Price = (int)12.99,
                        NumberOfPages = 416
                    },

                    new Book
                    {
                        Title = "The High King",
                        Author = "Lloyd Alexander",
                        Publisher = "Henry Holt and Company",
                        ISBN = "978-0006714996",
                        Category = "Fantasy",
                        Price = (int)5.36,
                        NumberOfPages = 288
                    }

                );

                context.SaveChanges();
            }
        }
    }
}
