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

    class Program {
        static void Main (string[] args) {
            // Create an instance of a company.
            Company NSS = new Company ("NSS", DateTime.Now);

            // Create three employees
            Employee Kimmy = new Employee ("Kimmy", "Bird", "Excellente Dev", DateTime.Now);
            Employee Meg = new Employee ("Meg", "Ducharme", "Awesomely Dev", DateTime.Now);
            Employee Jenna = new Employee ("Jenna", "Solis", "Fantastical Dev", DateTime.Now);
            Employee Steve = new Employee ("Steve", "Brownlee", "Fearless Lead Instructor", DateTime.Now);
            Employee Andy = new Employee ("Andy", "Collins", "Expert Tech Guy", DateTime.Now);

            // create employee list
            List<Employee> employees = new List<Employee> ();

            // add employees to list
            employees.Add (Kimmy);
            employees.Add (Meg);
            employees.Add (Jenna);
            employees.Add (Steve);
            employees.Add (Andy);

            // Assign the employees list to the company
            NSS.currentEmployees = employees;

            // invoke list employees method on company
            NSS.ListEmployees ();
        }
    }
}