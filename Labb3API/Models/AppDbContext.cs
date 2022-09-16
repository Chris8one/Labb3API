using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb3API.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PersonInterest> PersonInterests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Persons
            modelBuilder.Entity<Person>()
                .HasData(new Person
                {
                    PersonId = 1,
                    FirstName = "Jason",
                    LastName = "Voorhees",
                    Phone = "555-123-4567",
                    Email = "jason.voorhees@friday13th.com"
                });

            modelBuilder.Entity<Person>()
                .HasData(new Person
                {
                    PersonId = 2,
                    FirstName = "Michael",
                    LastName = "Myers",
                    Phone = "555-123-4657",
                    Email = "michael.myers@halloween.com"
                });

            modelBuilder.Entity<Person>()
                .HasData(new Person
                {
                    PersonId = 3,
                    FirstName = "Freddie",
                    LastName = "Krueger",
                    Phone = "555-123-7564",
                    Email = "freddie.krueger@terroronelmstreet.com"
                });

            modelBuilder.Entity<Person>()
                .HasData(new Person
                {
                    PersonId = 4,
                    FirstName = "Hannibal",
                    LastName = "Lecter",
                    Phone = "555-123-5476",
                    Email = "hannibal.lecter@thesilenceofthelambs.com"
                });

            // Seed Interests
            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 1,
                    InterestTitle = "Lake houses",
                    InterestDescription = "Loves to run around the lake house after submerged from the lake and scare and slaughter teenagers",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 2,
                    InterestTitle = "Halloween",
                    InterestDescription = "Hunt people at halloween",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 3,
                    InterestTitle = "Dreams",
                    InterestDescription = "To roam in peoples dreams and take them out",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 4,
                    InterestTitle = "To eat",
                    InterestDescription = "Likes to cook meat, but not animal meat as the rest of us eats",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 5,
                    InterestTitle = "Machetes",
                    InterestDescription = "Big machetetes is a favorite",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 6,
                    InterestTitle = "Hockey masks",
                    InterestDescription = "Old school hockey masks, used to cover a rotten face from a drowning",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 7,
                    InterestTitle = "Custom gloves",
                    InterestDescription = "Loves to make custom gloves.. especially with razor sharp knives on the fingers",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 8,
                    InterestTitle = "Halloween mask",
                    InterestDescription = "Just like Jason Voorhees, Michael likes to wear a mask over his face, but not an old hockey mask.. but both wear white masks",
                });

            modelBuilder.Entity<Interest>()
                .HasData(new Interest
                {
                    InterestId = 9,
                    InterestTitle = "Lake houses",
                    InterestDescription = "Loves to run around the lake house after submerged from the lake and scare and slaughter teenagers",
                });

            // Seed Links
            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 1,
                    LinkDescription = "A clip of Jason in action",
                    LinkUrl = "https://www.youtube.com/watch?v=yfxQmKO041o",
                    PersonId = 1,
                    InterestId = 1
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 2,
                    LinkDescription = "A clip of Michael doing what he does at halloween night",
                    LinkUrl = "https://www.youtube.com/watch?v=R-HV-gTRqag",
                    PersonId = 2,
                    InterestId = 2
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 3,
                    LinkDescription = "Freddie does his thing",
                    LinkUrl = "https://www.youtube.com/watch?v=HcrTqof683A",
                    PersonId = 3,
                    InterestId = 3
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 4,
                    LinkDescription = "Hannibal in prison",
                    LinkUrl = "https://www.youtube.com/watch?v=s3nIw30hn4U",
                    PersonId = 4,
                    InterestId = 4
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 5,
                    LinkDescription = "A clip of Freddie making gloves",
                    LinkUrl = "https://www.youtube.com/watch?v=FnEmVboDO0Q",
                    PersonId = 3,
                    InterestId = 7
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 6,
                    LinkDescription = "Jason shows off his Machete",
                    LinkUrl = "https://www.youtube.com/watch?v=p2ff-fiJAcs",
                    PersonId = 1,
                    InterestId = 5
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 7,
                    LinkDescription = "Michael Myers got his mask taken off",
                    LinkUrl = "https://www.youtube.com/watch?v=9dQ5Q7ILApE",
                    PersonId = 2,
                    InterestId = 8
                });

            modelBuilder.Entity<Link>()
                .HasData(new Link
                {
                    LinkId = 8,
                    LinkDescription = "Jason Voorhees with his mask",
                    LinkUrl = "https://www.youtube.com/watch?v=CflcJ-HSA_Y",
                    PersonId = 1,
                    InterestId = 6
                });

            // Seed PersonInterest Joins
            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 1,
                    InterestId = 1,
                    PersonId = 1
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 2,
                    InterestId = 2,
                    PersonId = 2
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 3,
                    InterestId = 3,
                    PersonId = 3
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 4,
                    InterestId = 4,
                    PersonId = 4
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 5,
                    InterestId = 5,
                    PersonId = 1
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 6,
                    InterestId = 6,
                    PersonId = 1
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 7,
                    InterestId = 7,
                    PersonId = 3
                });

            modelBuilder.Entity<PersonInterest>()
                .HasData(new PersonInterest
                {
                    PersonInterestId = 8,
                    InterestId = 8,
                    PersonId = 2
                });
        }
    }
}
