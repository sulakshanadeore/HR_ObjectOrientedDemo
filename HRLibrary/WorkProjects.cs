using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class WorkProjects
    {
        public int ProjectId { get; private set; }
        public string ProjectName { get; private set; }
        public int Duration { get; private set; }

        public WorkProjects()
        {
            
        }

        public WorkProjects(int projid,string projname,int dur)
        {
           ProjectId = projid;
            ProjectName = projname;
            Duration = dur;
        }

        public DateTime CalculateEndDate() 
        {
       DateTime endsOn= DateTime.Now.AddMonths(Duration);
            return endsOn;
        
        }




    }
}
