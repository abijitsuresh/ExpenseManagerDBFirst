//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpenseManagerDBFirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Income
    {
        public int IncomeID { get; set; }
        public string IncomeName { get; set; }
        public string IncomeAmount { get; set; }
        public int UserID { get; set; }
    
        public virtual User User { get; set; }
    }
}
