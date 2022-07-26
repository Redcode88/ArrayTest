using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [ForeignKey("UnitId")]
        public int UnitId { get; set; }

        public Unit Units { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        public float MinPrice { get; set; }

        [DataType(DataType.Currency)]
        public float MixPrice { get; set; }


        [ForeignKey("OrderDetailsId")]
        public int OrderDetailsId { get; set; }

        public OrderDetails OrderDetails { get; set; }


    }
}
