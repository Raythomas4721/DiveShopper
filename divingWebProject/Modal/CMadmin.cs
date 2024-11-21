using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CMadmin
    {
        public int adminId { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public string passwordHash { get; set; }
        public string roleName { get; set; }
        public DateTime createAt { get; set; }
        public DateTime lastLogin { get; set; }
    }
}
