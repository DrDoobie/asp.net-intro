using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_demo.Models
{
    public class PersonModel {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int birthYear { get; set; }  
        public bool isLiving { get; set; } = true;
    }
}