namespace EmployeeSalaryCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Salary Calculator");
            Console.WriteLine("---------------------------");

            Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            double basicSalary = Convert.ToDouble(Console.ReadLine());

            CalculateSalary(employeeName, basicSalary);
        }

        static void CalculateSalary(string employeeName, double basicSalary)
        {
            double hra = basicSalary * 0.20;
            double allowance = basicSalary * 0.10;
            double tax = basicSalary * 0.05;

            double netSalary = basicSalary + hra + allowance - tax;

            Console.WriteLine("\nSalary Breakdown");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Employee Name: " + employeeName);
            Console.WriteLine("Basic Salary: " + basicSalary);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("Allowance: " + allowance);
            Console.WriteLine("Tax Deduction: " + tax);
            Console.WriteLine("Net Salary: " + netSalary);
        }
    }
}