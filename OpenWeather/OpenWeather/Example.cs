using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeather
{
    public class Example
    {
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public Current current { get; set; }
        public IList<Daily> daily { get; set; }
    }
}
