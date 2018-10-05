using System;
using System.Collections.Generic;

namespace classes_v2 {
    class Program {
        static void Main (string[] args) {
            // Create an instance of a company.
            Company NSS = new Company ("NSS", DateTime.Now);

            // Create employees
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