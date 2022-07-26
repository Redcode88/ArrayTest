using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModel
{
    public class SalesRepresentatives : Employee
    {
        public override float CalculateBouns()
        {
            //you can preform your b-case here its Empty abstract Do what you want 
            // Easy to edit 
            //Dummy Data ..
            var result = (Salary * CommissionRate);
            return result;
        }
    }
}
