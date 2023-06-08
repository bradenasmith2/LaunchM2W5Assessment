using M2W5Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment.Data
{
    public class SeedData
    {
        public static void SeedConcertsAndPerformers(ConcertContext context)
        {
            if (!context.Concerts.Any() && !context.Performers.Any())
            {
                var concerts = new List<Concert>();
                {
                    new Concert
                    {
                        Name = "Tour 1",
                        ShowDate = DateTime.Now,
                        Performers = { }
                    };
                    new Concert
                    {
                        Name = "Tour 2",
                        ShowDate = DateTime.Now,
                        Performers = { }
                    };
                }
                var performers = new List<Performer>();
                {
                    new Performer
                    {
                        Name = "Performer 1",
                        Genre = "Music",
                        Concerts = { concerts[0] }
                    };
                    new Performer
                    {
                        Name = "Performer 2",
                        Genre = "Music 2",
                        Concerts = { concerts[0], concerts[1] }
                    };
                }
                context.Concerts.AddRange(concerts);
                context.Performers.AddRange(performers);
                context.SaveChanges();
            }
        }
    }
}
