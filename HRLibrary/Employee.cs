namespace HRLibrary
{
    public class Employee
    {
        static int _empno;
        string? _fname, _lname, _city;
        long? _adharno;

//Read-Write
        public string FirstName
        {
            set { _fname = value; }
            get { return _fname; }
        }



        static Employee()
        {
            _empno = 0;
            Console.WriteLine("empno initialized....");
        }

        //public Employee()
        //{
                
        //}

        public Employee(string Firstname, string LastName, string city,string streetname,string country):this(Firstname,LastName,city,streetname)
        {
            this.Country = country;
        }

        public string Country { get; set; }
        public string StreetName { get; set; }
        public Employee(string Firstname, string LastName, string city, string streetname):this(Firstname,LastName,city)
        {
           this.StreetName = streetname;
        }
        public Employee(string Firstname, string LastName, string city):this(Firstname,LastName)
        {
            this._city = city;
        }
        public Employee(string Firstname,string LastName)
        {
            this._fname = Firstname;
            this._lname = LastName;
            this.FullName=string.Concat(this._fname, this._lname);
        }
        public string FullName { get; set; }


        //Read only
        public int Empno
        {
            get { 
            
            _empno++;
                return _empno;
            }
        }


        //Write Only
        public long AadharID
        {
            set { _adharno = value; }
        
        }

        private DateTime _doj;

        public DateTime JoiningDate
        {
            get { return _doj; }
            set { _doj = value; }
        }


















    }
}
