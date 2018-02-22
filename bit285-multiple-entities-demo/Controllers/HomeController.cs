using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndyBooks.Models;
using IndyBooks.ViewModels;

namespace IndyBooks.Controllers
{
    public class HomeController : Controller
    {
        BookstoreDbContext db = new BookstoreDbContext();

        /*
         * Purchase Creation and List
         */
        public ActionResult Purchase()
        {
            var pvm = new PurchaseViewModel();  // creates a new viewmodel object and
            pvm.Books = db.Books;               // assigns values to viewmodel collections
            pvm.Members = db.Members;

            return View(pvm);
        }
        [HttpPost]
        public ActionResult Purchase(Purchase purchase)
        {
            if(ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return View("Purchases", db.Purchases);
            }
            return View();
        }
        /*
         * Book Creation and List
         */
        public ActionResult AddBook()
        {
            //TODO: Create a new ViewModel object, assign values to its collections, and pass it to the View
            var bvm = new BookViewModel();
            bvm.Authors = db.Authors;      // assigns values to viewmodel collections
            return View(bvm);
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return View("Books", db.Books);
            }
            //TODO: Update your Book Listing  View to display the Authors Full Name, rather than the AuthorID
            return View();
        }

        //Modify the Home Controller to include methods for creating and 
        //listing a new Book that includes a Dropdown list for possible 
        //authors instead of an AuthorID. The resulting Book Listing View 
        //should show the Author's full name for each Book
    }
}