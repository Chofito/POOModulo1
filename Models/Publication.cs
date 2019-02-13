using System;
using System.Collections.Generic;

namespace POOTarea1.Models
{
    public abstract class Publication
    {
        public string Title { get; set; }
        public DateTime EditionDate { get; set; }
        public string Editorial { get; set; }
        public IList<string> Authors { get; set; }
    }
}