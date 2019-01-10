using System;
using System.Collections.Generic;

namespace cpsAngular.Models
{
    public partial class FormFields
    {
        public int FieldId { get; set; }
        public string FieldName { get; set; }
        public int SnippetId { get; set; }

        public virtual Snippet Snippet { get; set; }
    }
}
