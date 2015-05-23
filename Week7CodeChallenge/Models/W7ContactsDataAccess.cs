﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Week7CodeChallenge.Models
{
    public class ContactDataContext : DbContext
    {
        public virtual DbSet<W7Contact> W7Contacts { get; set; }
                
        public ContactDataContext(): base("DefaultConnection")
        {

        }
    }
}