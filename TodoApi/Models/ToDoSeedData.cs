﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace TodoApi.Models;

public static class ToDoSeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TodoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TodoContext>>()))
        {
            if (context.Concert.Any())
            {
                return;
            }
            context.Concert.AddRange(
                new Concert
                {
                    Title = "Avicii",
                    Description = "DJ",
                    Duration = 3,
                    Price = 180,
                    Genre = "House"

                },
                new Concert
                {
                    Title = "Dr.Dre",
                    Description = "Rapper",
                    Duration = 1,
                    Price = 260,
                    Genre = "Rap"
                },
                new Concert
                {
                    Title = "Leon",
                    Description = "Chill",
                    Duration = 3,
                    Price = 160,
                    Genre = "Blues"

                },
                new Concert
                {
                    Title = "Steve Wonder",
                    Description = "Blind Legend",
                    Duration = 1,
                    Price = 110,
                    Genre = "Soul"

                },
                new Concert
                {
                    Title = "Marsmellow",
                    Description = "DJ",
                    Duration = 2,
                    Price = 220,
                    Genre = "Trance"

                },
                new Concert
                {
                    Title = "David Guetta",
                    Description = "DJ",
                    Duration = 2,
                    Price = 220,
                    Genre = "Techno"
                }
            );
            context.SaveChanges();

           

            if (context.Show.Any())
            {
                return;
            }

            context.Show.AddRange(

                new Show()
                {
                    ConcertId = 1,
                    Location = "Gamla Ullevi",
                    DateTime = DateTime.Now.AddDays(10),
                },

                new Show()
                {
                    ConcertId = 2,
                    Location = "Nya Ullevi",
                    DateTime = DateTime.Now.AddDays(15),

                },

                new Show()
                {
                    ConcertId = 3,
                    Location = "NyGamla Ullevi",
                    DateTime = DateTime.Now.AddDays(20),

                },

                new Show()
                {
                    ConcertId = 4,
                    Location = "Globen",
                    DateTime = DateTime.Now.AddDays(25),

                },

                new Show()
                {
                    ConcertId = 5,
                    Location = "Friends Arena",
                    DateTime = DateTime.Now.AddDays(30),

                },

                new Show()
                {
                    ConcertId = 6,
                    Location = "SlottSkogen",
                    DateTime = DateTime.Now.AddDays(35),

                }
            );

            context.SaveChanges();


            
        }
    }
}
