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
        public string coachPhone { get; set; }
        public string experience { get; set; }
        public byte[] photo { get; set; }
        public int divingStyleId {get; set;}
    }
}
