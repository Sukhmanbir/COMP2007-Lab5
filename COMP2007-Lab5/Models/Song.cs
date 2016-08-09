using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COMP2007_Lab5.Models
{
    public class Song
    {
        public virtual int SongID { get; set; }
        public virtual string Name { get; set; }
        public virtual int Duration { get; set; }
    }
}
