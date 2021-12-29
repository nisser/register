using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace register.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }

        public Entry()
        {

        }
    }
}