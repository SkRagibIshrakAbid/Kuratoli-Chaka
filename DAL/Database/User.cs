//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.BusInfoes = new HashSet<BusInfo>();
            this.BusInfoes1 = new HashSet<BusInfo>();
            this.Carts = new HashSet<Cart>();
            this.SoldTickets = new HashSet<SoldTicket>();
            this.Tokens = new HashSet<Token>();
        }
    
        public int U_Id { get; set; }
        public string U_UserName { get; set; }
        public string U_Password { get; set; }
        public string U_Phone { get; set; }
        public string U_Email { get; set; }
        public string U_Address { get; set; }
        public string U_Gender { get; set; }
        public string U_DateofBirth { get; set; }
        public string U_Role { get; set; }
        public string U_Status { get; set; }
    
        public virtual ICollection<BusInfo> BusInfoes { get; set; }
        public virtual ICollection<BusInfo> BusInfoes1 { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
        public virtual ICollection<SoldTicket> SoldTickets { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}