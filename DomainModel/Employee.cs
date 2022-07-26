using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainModel
{
   public abstract class Employee
   {
        [Key]
        public int EmployeeId { get; set; }
        
        // build Index(Entity<Name>().hasIndex("indexName")) Constraint onModulCreate Methoed on DbContxt Class
        //to set this filed uniqe 
        public long GovernmentId { get; set; }

        [Required]
        [MaxLength(12)]
        public long PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public float Salary { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [Required]
        [MaxLength(3)]
        public int Age { get; set; }

        public float CommissionRate { get; set; }

        public abstract float CalculateBouns();

    }
}
