//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string roll_number { get; set; }
        public Nullable<int> subject_1 { get; set; }
        public Nullable<int> subject_2 { get; set; }
        public Nullable<int> subject_3 { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> average { get; set; }
        public string grade { get; set; }
    }
}
