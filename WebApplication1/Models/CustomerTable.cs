//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerTable
    {
        public CustomerTable()
        {
            this.Children = new HashSet<Child>();
        }
    
        public string AccNo { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    
        public virtual ICollection<Child> Children { get; set; }
    }
}
