﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week7CodeChallenge.Models
{
    public class W7Contact
    {
        //properties
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required, EmailAddressAttribute]
        public string Email { get; set; }
        [Required, Phone]
        public int Phone { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string ProjectDescription { get; set; }
        [Required]
        public string Comment { get; set; }
    }
}