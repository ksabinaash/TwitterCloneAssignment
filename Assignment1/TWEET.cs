//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TWEET
    {
        public int tweet_id { get; set; }
        public string user_id { get; set; }
        public string message { get; set; }
        public System.DateTime created { get; set; }
    
        public virtual PERSON PERSON { get; set; }
    }
}
