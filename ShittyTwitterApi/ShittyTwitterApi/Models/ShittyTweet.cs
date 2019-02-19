using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShittyTwitterApi.Models
{
    public class ShittyTweet
    {
        public int ID { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
    }
}
