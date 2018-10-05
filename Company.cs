using System;
using System.Collections.Generic;

namespace classes_v2 {
    public class Company {

        // Some readonly properties 
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> currentEmployees { get; set; }

        /*
            Constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
        */
        public Company (string name, DateTime createdOn) {
            Name = name;
            CreatedOn = createdOn;
        }

        // ListEmployees() method which outputs the name of each employee to the console.
        public void ListEmployees () {
            foreach (Employee e in currentEmployees) {
                Console.WriteLine ($"{e.firstName} {e.lastName} works for {this.Name} as {e.title} since {e.startDate}");
            }
        }
    }
}