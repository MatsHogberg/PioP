//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ontime
    {
        public int ontime_Id { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public Nullable<decimal> value { get; set; }
        public string comment { get; set; }
        public int project_Id { get; set; }
    }
}
