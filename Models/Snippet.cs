using System;
using System.Collections.Generic;

namespace cpsAngular.Models
{
    public partial class Snippet
    {
        public Snippet()
        {
            Footers = new HashSet<Footers>();
            FormFields = new HashSet<FormFields>();
        }

        public string Snippet1 { get; set; }
        public int SnippetId { get; set; }

        public virtual ICollection<Footers> Footers { get; set; }
        public virtual ICollection<FormFields> FormFields { get; set; }
    }
}
