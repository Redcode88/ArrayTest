using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainModel
{
    public class Customer 
    {

        [Key]
        public int AccountId { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string CustomerEmail { get; set; }

        [Required]
        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [StringLength(12)]
        public string PhoneNumber { get; set; }


        [Required]
        [MaxLength(3)]
        public int Age { get; set; }


        public virtual ICollection<Order> Orders { get; set; }
    }
}
