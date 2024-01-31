using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaySpace.Model.Models
{
    public class CalculatorResponse
    {
        public double AnnualIncome { get; set; }
        public string PostalCode { get; set; } = string.Empty;
        public double CalculatedValue { get; set; }
        public DateTime DateTime { get; set; }
    }
}
