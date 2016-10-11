using System.Collections.Generic;

namespace Mocking
{
    public class Employee
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }
        public MailBox MailBox { get; set; }

        public double CalculateWeeklySalary(int hours, int eWage)
        {
            return eWage * hours;
        }

        public static double calculateAverageWeeklySalary(List<Employee> employees)
        {
            double Average = 0;
            foreach (Employee employee in employees)
            {
                Average += employee.CalculateWeeklySalary(employee.Wage, 42);
            }
            return Average = Average/employees.Count;
        }
    }
}