using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CCourse
    {
        public int courseId { get; set; }
        public int courseCategoryId { get; set; }
        public int levelId { get; set; }
        public int coachId { get; set; }
        public decimal coursePrice { get; set; }
        public byte[] photo { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; } 
    }
}
