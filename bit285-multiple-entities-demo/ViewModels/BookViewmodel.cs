﻿using IndyBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.ViewModels
{
    public class BookViewModel
    {
        public Book Book { get; set; }
 
        public IEnumerable<Author> Authors { get; set; }


}
}