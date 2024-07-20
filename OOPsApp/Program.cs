

using HRLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        



        Employee employee = new Employee();
        Console.WriteLine("Enter first name ");
        string? firstname=Console.ReadLine();
        Console.WriteLine("Enter LastName");
        string? lastname=Console.ReadLine();
        Console.WriteLine("Enter City");
        string? city=Console.ReadLine();
        Console.WriteLine("Enter Aadhar No");
        long? adhar=Convert.ToInt64(Console.ReadLine());
        int empno=employee.NewEmployee(firstname,lastname,city,adhar);
        Console.WriteLine("Printing details... You entered the following");
        employee.PrintData();
        Console.WriteLine($"Generated EmployeeNumber={empno}");

        Console.Read();
    }
}