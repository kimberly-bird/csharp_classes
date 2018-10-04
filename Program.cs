using System;
using System.Collections.Generic;

namespace classes_v2 {
    public class Company {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> currentEmployees { get; set; }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string name, DateTime createdOn) {
            Name = name;
            CreatedOn = createdOn;
        }

        // The Company class should also have a ListEmployees() method which outputs the name of each employee to the console.
        public void ListEmployees () {
            foreach (Employee e in currentEmployees) {
                Console.WriteLine ($"{e.firstName} {e.lastName} works for {this.Name} as a {e.title} since {e.startDate}");
            }
        }
    }

    public class Employee {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public DateTime startDate { get; set; }

        public Employee (string FirstName, string LastName, string Title, DateTime StartDate) {
            firstName = FirstName;
            lastName = LastName;
            title = Title;
            startDate = StartDate;
        }
    }

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.
            Company NSS = new Company ("NSS", DateTime.Now);

            // Create three employees
            Employee Kimmy = new Employee ("Kimmy", "Bird", "Dev", DateTime.Now);
            Employee Meg = new Employee ("Meg", "Ducharme", "Dev", DateTime.Now);
            Employee Jenna = new Employee ("Jenna", "Solis", "Dev", DateTime.Now);

            // create employee list
            List<Employee> employees = new List<Employee> ();

            // add employees to list
            employees.Add (Kimmy);
            employees.Add (Meg);
            employees.Add (Jenna);

            // Assign the employees list to the company
            NSS.currentEmployees = employees;

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            NSS.ListEmployees();
        }
    }
}