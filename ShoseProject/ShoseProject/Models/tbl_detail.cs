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
    
    public partial class tbl_detail
    {
        public int idx { get; set; }
        public string nameItem { get; set; }
        public string decription { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> typeStyleID { get; set; }
        public Nullable<int> typeColourID { get; set; }
        public Nullable<int> qty { get; set; }
        public string image { get; set; }
    
        public virtual tbl_typeColour tbl_typeColour { get; set; }
        public virtual tbl_typestyle tbl_typestyle { get; set; }
    }
}