using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CSite
    {
        public int siteId {  get; set; }
        public string venueName { get; set; }
        public int numberOfPeople { get; set; }
        public string venueAddress { get; set; }
        public string detail { get; set; }
        public string state { get; set; }
        public byte[] photo { get; set; }
    }
}
