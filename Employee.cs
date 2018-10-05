using System;
using System.Collections.Generic;

namespace classes_v2 {

    public class Employee {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime startDate { get; set; }

        /*
            Constructor method that accepts two arguments:
                1. Employee first name
                2. Employee last name
                3. Employee title
                4. Employee start date
        */
        public Employee (string FirstName, string LastName, string Title, DateTime StartDate) {
            firstName = FirstName;
            lastName = LastName;
            title = Title;
            startDate = StartDate;
        }
    }
}