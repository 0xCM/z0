//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 

    public class PropInfoAttribute : Attribute
    {
        public PropInfoAttribute(string Name, string desc = "", int Width = 0)
        {
            this.Name = Name;
            this.Desc = desc;
            this.Width = Width == 0 ? (int?)null : Width;
        }
        
        public string Name {get;}

        public string Desc {get;}
        
        public int? Width {get;}
    }
}