//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoseProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_typestyle
    {
        public tbl_typestyle()
        {
            this.tbl_detail = new HashSet<tbl_detail>();
        }
    
        public int typeStyleID { get; set; }
        public string typeName { get; set; }
    
        public virtual ICollection<tbl_detail> tbl_detail { get; set; }
    }
}
