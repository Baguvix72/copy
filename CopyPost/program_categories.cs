//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CopyPost
{
    using System;
    using System.Collections.Generic;
    
    public partial class program_categories
    {
        public int id { get; set; }
        public int programs_id { get; set; }
        public int categories_id { get; set; }
    
        public virtual categories categories { get; set; }
        public virtual programs programs { get; set; }
    }
}
