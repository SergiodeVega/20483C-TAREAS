//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FourthCoffee.Employees
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employees
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> Branch { get; set; }
        public Nullable<int> JobTitle { get; set; }
    
        public virtual Branches Branches { get; set; }
        public virtual JobTitles JobTitles { get; set; }
    }
}
