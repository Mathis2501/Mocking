namespace Mocking
{
    public class Employee
    {
        public int Id { get; internal set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Wage { get; set; }
        public object MailBox { get; set; }

        public double CalculateWeeklySalary(int hours, int eWage)
        {
            return eWage * hours;
        }
    }
}