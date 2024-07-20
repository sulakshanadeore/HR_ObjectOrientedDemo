namespace HRLibrary
{
    public class Employee
    {
        static int _empno;
        string? _fname, _lname, _city;
        long? _adharno;

        static Employee()
        {
            _empno = 0;
            Console.WriteLine("empno initialized....");
        }
        public int NewEmployee(string? fname,string? lname,string? city,long? adharno)
        {
            _empno++;


            this._fname = fname;
            this._lname = lname;
            this._city = city;
            this._adharno = adharno;    
        return _empno;
        }

        public void PrintData()
        {
            Console.WriteLine(this._fname);
            Console.WriteLine(this._lname);
            Console.WriteLine(this._city);
            Console.WriteLine(this._adharno);

        }




    }
}
