//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Suplanus.Eplan.Database.Parts
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAccessoryPosition
    {
        public int id { get; set; }
        public string partnr { get; set; }
        public short pos { get; set; }
        public string variant { get; set; }
        public bool necessary { get; set; }
        public Nullable<short> parttype { get; set; }
        public string placement { get; set; }
        public int C_uniqueid { get; set; }
    }
}
