using System;
public class Employee
{
    public static int NumberOfEmployees = 0;
    public static void DisplayNumberOfEmployee()
    {
        System.Console.WriteLine("Number of Employees:" + NumberOfEmployees);
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Name:" + Name);
        Console.WriteLine("Age:" + Age);
    }
    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
        NumberOfEmployees++;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Employee.DisplayNumberOfEmployee();
        Employee emp1=new Employee("Vd",19);
        emp1.DisplayEmployeeDetails();
        Employee.DisplayNumberOfEmployee();
        Employee emp2 = new Employee("Dharshini", 18);
        emp2.DisplayEmployeeDetails();
        Employee.DisplayNumberOfEmployee();

    }
}
