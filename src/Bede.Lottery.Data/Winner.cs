//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bede.Lottery.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Winner
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string PrizeDraw { get; set; }
        public int PrizeId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Prize Prize { get; set; }
    }
}
