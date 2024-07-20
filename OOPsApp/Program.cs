using HRLibrary;

internal class Program
{
    private static void Main(string[] args)
    {

        Employee emp = new Employee("Amitabh", "Bachhan", "Mumbai", "Galaxy", "India");
        Console.WriteLine(emp.FullName);



        //Dept d = new Dept();
        //Console.WriteLine("Enter Deptno");
        //d.Deptno=Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Enter Deptanme");
        //d.DeptName = Console.ReadLine();
        //Console.WriteLine($"The Deptno you entered is {d.Deptno}");
        //Console.WriteLine($"The Dname= {d.DeptName}");
        //Console.WriteLine("----------------------------------");
        //Employee emp = new Employee();
        //Console.WriteLine("Enter First NAme");
        //emp.FirstName = Console.ReadLine();
        //Console.WriteLine("Enter Joining date--dd/mm/yyyy or yyyy-month-day");
        //emp.JoiningDate = Convert.ToDateTime(Console.ReadLine());
        //DateTime trainingEnds=emp.JoiningDate.AddDays(-44);
        //Console.WriteLine(trainingEnds);
        // TimeSpan t=TimeSpan.FromDays(1);
        //Console.WriteLine(t);
        // DateTime current=DateTime.Now;
        //DateTime dt= current.AddHours(2);
        // Console.WriteLine(dt);
        // TimeSpan diff= DateTime.Now - dt;
        // Console.WriteLine(diff);

        //var t=TimeSpan.FromMinutes(20);
        //var h = TimeSpan.FromHours(1);
        //var a = t + h;
        //Console.WriteLine(a);
        //TimeSpan t1 = new TimeSpan();
        //TimeSpan t2=new TimeSpan(seconds:30,hours:1,minutes:1);

        //WorkProjects p = new WorkProjects(projid: 1, projname: "Uber", dur: 24);
        //Console.WriteLine(p.ProjectId);
        //Console.WriteLine(p.ProjectName);
        //Console.WriteLine(p.Duration);
        //Console.WriteLine(p.CalculateEndDate());
        //Console.WriteLine("-------------------");
        //WorkProjects p1 = new WorkProjects(projid: 1, projname: "Uber", dur: 24);
        //Console.WriteLine(p1.ProjectId);
        //Console.WriteLine(p1.ProjectName);
        //Console.WriteLine(p1.Duration);
        //Console.WriteLine(p1.CalculateEndDate());
        //Console.WriteLine("--------------------");

        //object o=p.ProjectName.ToString() + p.ProjectId.ToString() + p.Duration.ToString();
        //Console.WriteLine(o);//Uber124
        //object o1 = p1.ProjectName.ToString() + p1.ProjectId.ToString() + p1.Duration.ToString();
        //Console.WriteLine(o1);//
        //bool ans=o.Equals(o1);//Uber124
        //Console.WriteLine(ans);
        ////bool ans= string.Equals(s, s1);
        //bool ans = s.Equals(s1);
        // Console.WriteLine(ans);

        //bool ans=p.Duration.Equals(p1.Duration);

        //bool ans=p.Equals(p);
        //Console.WriteLine(ans);



        //Console.WriteLine(emp.JoiningDate);

        //Console.WriteLine(emp.JoiningDate.Day);
        //Console.WriteLine(emp.JoiningDate.Month);
        //Console.WriteLine(emp.JoiningDate.Year);
        //Console.WriteLine("---------------------");
        //Console.WriteLine("Hour= " + DateTime.Now.Hour);
        //Console.WriteLine("Minute= " + DateTime.Now.Minute);
        //Console.WriteLine("Second= "+ DateTime.Now.Second);
        //Console.WriteLine("Millisecond =" + DateTime.Now.Millisecond);
        //int days=DateTime.DaysInMonth(2024, 7);
        //Console.WriteLine($"Days in  a month={days}");
        //bool isleapYear=DateTime.IsLeapYear(2024);
        //Console.WriteLine(isleapYear);

















        //  Console.WriteLine($"Thanks for the input .. ur empid = {emp.Empno}");



        // Console.WriteLine("Hello, World!");




        // Employee employee = new Employee();
        // Console.WriteLine("Enter first name ");
        // employee.FirstName=Console.ReadLine();
        //int empno= employee.NewEmployee();
        // Console.WriteLine(empno);

        //Console.WriteLine("Enter LastName");
        //string? lastname=Console.ReadLine();
        //Console.WriteLine("Enter City");
        //string? city=Console.ReadLine();
        //Console.WriteLine("Enter Aadhar No");
        //long? adhar=Convert.ToInt64(Console.ReadLine());
        //int empno=employee.NewEmployee(firstname,lastname,city,adhar);
        //Console.WriteLine("Printing details... You entered the following");
        //Console.WriteLine(employee.FirstName);


        //employee.PrintData();


        Console.Read();
    }
}