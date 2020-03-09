using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionApp2.Models
{
    public class Student
    {
        public long ID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime birthDate { get; set; }
        public String gender { get; set; }
        public String address { get; set; }

    }
}