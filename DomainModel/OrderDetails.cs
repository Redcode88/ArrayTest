using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainModel
{
  public  class OrderDetails
  {
        [Key]
        public int OrderDetailsId { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        
        public int Qut { get; set; }

        public float TotalPrice { get; set; }

        public float Disscount { get; set; }


    }
}
