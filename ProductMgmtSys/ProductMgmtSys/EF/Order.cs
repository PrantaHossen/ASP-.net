//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductMgmtSys.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public Order()
        {
            this.OrderProducts = new HashSet<OrderProduct>();
        }
    
        public int Id { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public System.DateTime OrderDate { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual User User { get; set; }
    }
}
