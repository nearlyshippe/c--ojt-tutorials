//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fitnessTracker
{
    using System;
    using System.Collections.Generic;
    
    public partial class staffInfo
    {
        public int ID { get; set; }
        public string staffNo { get; set; }
        public string staffName { get; set; }
        public System.DateTime staffDob { get; set; }
        public System.DateTime staffJoin { get; set; }
        public short staffType { get; set; }
        public string staffNRC { get; set; }
        public short staffGender { get; set; }
        public string staffPhone1 { get; set; }
        public string staffPhone2 { get; set; }
        public string staffAddress { get; set; }
        public string photo { get; set; }
        public short is_deleted { get; set; }
        public string password { get; set; }
    }
}
