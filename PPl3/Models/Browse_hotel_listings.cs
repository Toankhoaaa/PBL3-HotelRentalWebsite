//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPl3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Browse_hotel_listings
    {
        public int id { get; set; }
        public Nullable<int> property_id { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual property property { get; set; }
    }
}
