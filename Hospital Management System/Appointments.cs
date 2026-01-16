using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Appointments7
    {

        public class Appointment
        {
            public int Id { get; set; }
            public string Patient { get; set; }
            public string Doctor { get; set; }
            public DateTime Date { get; set; }
            public string Status { get; set; }
        }


    }
}
