using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainModel
{
    public class Unit
    {
        [Key]
        public int UnitId { get; set; }

        [Required]
        [StringLength(25)]
        public string UnitName { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
