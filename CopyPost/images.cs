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
    
    public partial class images
    {
        public int id { get; set; }
        public string href { get; set; }
        public int posts_id { get; set; }
    
        public virtual posts posts { get; set; }
    }
}
