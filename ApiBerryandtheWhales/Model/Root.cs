using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBerryandtheWhales.Model
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Root
    {
        public string result { get; set; }
        public int table { get; set; }
        public string _start { get; set; }
        public string _stop { get; set; }
        public DateTime _time { get; set; }
        public double _value { get; set; }
        public string _field { get; set; }
        public string _measurement { get; set; }
    }
}
