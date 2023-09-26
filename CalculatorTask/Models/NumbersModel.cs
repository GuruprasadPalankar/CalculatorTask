using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CalculatorTask.Models
{
    public class NumbersModel
    {
        [Required(ErrorMessage = "Note: 1st number is mandatory field")]
        public double Number1 { get; set; }

        [Required(ErrorMessage = "Note: 2nd number is mandatory field")]
        public double Number2 { get; set; }

        public double Solution { get; set; }
    }
}