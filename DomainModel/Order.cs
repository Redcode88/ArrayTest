using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
   public class Order
   {
        [Key]
        public int OrderID { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Required]
        [DataType(DataType.Currency)]
        public float TotalPrice { get; set; }

        [ForeignKey("AccountId")]
        public int AccountId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
