using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }

        // TODO: Create at least three  appropriate properties
        public string Name { get; set; } 
        public string Address { get; set; }

        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"
        //add virtual property that represents all of the books. For each author we have a set of books that
        //references a table.
        public virtual ICollection<Book> Authored { get; set; }


    }
}