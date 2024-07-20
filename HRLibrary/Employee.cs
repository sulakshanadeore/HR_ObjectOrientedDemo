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
