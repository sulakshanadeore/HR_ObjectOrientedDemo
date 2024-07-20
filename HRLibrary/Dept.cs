using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Dept
    {
        private int _deptno;
        public int Deptno
        {
            get { return _deptno; }
            set 
            {
                if (value <= 0)
                {
                    Console.WriteLine("Invalid deptno");
                    Console.Read();
                    Environment.Exit(0);
                  //throw new ArgumentOutOfRangeException("Invalid deptno");
                }
                else
                {
                    _deptno = value;
                }
            }
        
        }


        private string _dname;

        public string DeptName
        {
            get { return _dname; }
            set {
                if (string.IsNullOrEmpty(value) || value.Length <4)
                {
                    Console.WriteLine("Enter a valid name greater than 4 characters");
                    Console.WriteLine("Exiting... press any key to continue");
                    Console.Read();
                    Environment.Exit(0);
                }
                else
                {
                    _dname = value;
                }
            } 
        }

    }
}
