//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<System.DateTime> HireDt { get; set; }
    
        public virtual Department Department { get; set; }

        internal EmployeeViewModel Select(Func<object, EmployeeViewModel> p)
        {
            throw new NotImplementedException();
        }
    }
}