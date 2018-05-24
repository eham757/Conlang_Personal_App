using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConlangWeb.Models
{
    public class Word
    {
        public int ID { get; set; }
        public string Dutch { get; set; }
        public string English { get; set; }
        public string Con { get; set; }
        public string Note { get; set; }
    }
}
