using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CMcoaches
    {
        public int coachId { get; set; }
        public string coachName { get; set; }
        public string gender { get; set; }
        public string experience { get; set; }
        public byte[] Photo { get; set; }
        public int divingStyleId { get; set; }
    }
    public class CMcoachDiving
    {
        public int coachDivingId { get; set; } 
        public int coachId { get; set; } 
        public int divingStyleId { get; set; }
    }

    public class CMdivingStyle
    {
        public int divingStyleId { get; set; } 
        public string divingStyle { get; set; } 
    }
}
