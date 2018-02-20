namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    AuthorID = 3,
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 3,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID = 2,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID = 1,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 1,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    AuthorID = 1,
                    Price = 9.95M

                });
            //TODO: Add several Author records
            context.Authors.AddOrUpdate(b => b.AuthorID,
               new Author()
               {
                   AuthorID = 1,
                   Name = "Ursula Le Guin"
               },
                 new Author()
                 {
                     AuthorID = 2,
                     Name = "Charles Dickens"
                 },
                   new Author()
                   {
                       AuthorID = 3,
                       Name = "Jane Austen"
                   },
                    new Author()
                    {
                        AuthorID = 4,
                        Name = "JK Rowling"
                    });
            //TODO: Add several Member records
            context.Members.AddOrUpdate(b => b.MemberID,
             new Member()
             {
                 MemberID = 1,
                 Name = "John Doe",
                 Purchases = 3
             },
                 new Member()
                 {
                     MemberID = 2,
                     Name = "Jane Doe",
                     Purchases = 5
                 
                 },
                  new Member()
                  {
                      MemberID = 3,
                      Name = "Ralph Smith",
                      Purchases = 4

                  },
                   new Member()
                   {
                       MemberID = 4,
                       Name = "Mary Anderson",
                       Purchases = 10

                   });

            //TODO: Add additional Purchase records
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,
                    //TODO: Add the MemberID value
                    MemberID = 1
                },
                 new Purchase()
                 {
                     PurchaseID = 2,
                     Amount = 13.00M,
                     BookID = 3,
                     //TODO: Add the MemberID value
                     MemberID = 2
                 },
                  new Purchase()
                  {
                      PurchaseID = 3,
                      Amount = 7.00M,
                      BookID = 3,
                      //TODO: Add the MemberID value
                      MemberID = 4
                  },
                   new Purchase()
                   {
                       PurchaseID = 4,
                       Amount = 10.00M,
                       BookID = 1,
                       //TODO: Add the MemberID value
                       MemberID = 1
                   });

        }
    }
}
