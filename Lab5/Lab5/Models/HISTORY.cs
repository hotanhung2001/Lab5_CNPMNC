//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab5.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HISTORY
    {
        public int History_ID { get; set; }
        public Nullable<int> IDTV { get; set; }
        public string HovaTen { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> NgayThamGia { get; set; }
        public string SDT { get; set; }
        public Nullable<int> DeleteFlag { get; set; }
        public Nullable<System.TimeSpan> DeleteTime { get; set; }
    }
}
