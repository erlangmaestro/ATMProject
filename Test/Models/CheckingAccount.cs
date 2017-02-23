﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        [Display (Name = "Account #")]
        [RegularExpression(@"\d{6,10}",ErrorMessage = ("Please enter a number between 6 and 10 characters"))]
        public string AccountNumber { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName); 
                
            }
        }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ApplicationUserId { get; set; }
    }
}