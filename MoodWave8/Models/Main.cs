//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MoodWave8.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Main
    {
        public int index { get; set; }
        public string UserName { get; set; }
        public string Track { get; set; }
        public string Artist { get; set; }
        public string Mood { get; set; }
    
        public virtual User User { get; set; }
    }
}
