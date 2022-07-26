﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace DomainModel
{
    public class Category
    {

        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(20)]
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
