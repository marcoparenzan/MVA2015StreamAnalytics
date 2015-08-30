using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLogSimulator
{

    public class ApiCall
    {
        public string Deployment { get; set; }
        public string Url { get; set; }
        public int Elapsed { get; set; }
        public int Size { get; set; }
        public DateTime CallTime { get; internal set; }
    }
}
