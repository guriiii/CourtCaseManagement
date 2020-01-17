using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourtCaseManagement.Models
{
    public class Hearing
    {
        public int ID { get; set; }
        public int CaseID { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime NextDate { get; set; }

        public Case Case { get; set; }
    }
}