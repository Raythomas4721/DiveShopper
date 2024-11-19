using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CMmember
    {
        public int memberId {  get; set; }
        public string memberName { get; set; }
        public string memberGender { get; set; }
        public string memberPhone { get; set; }
        public string memberEmail { get; set; }
        public string memberAddress { get; set;}
        public string memberPassword { get; set;}
        public byte[] memberPhoto { get; set;}
        public string urgentContact { get; set;}
        public string urgentPhone { get; set;}
        public DateTime recentLogin { get; set;}
    }
}
