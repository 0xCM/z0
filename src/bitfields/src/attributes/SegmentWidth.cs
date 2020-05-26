//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class SegmentWidthAttribute : Attribute
    {
        public SegmentWidthAttribute(string description)
        {
            this.Description = (string)description;
        }

        public string Description {get;}            
    }  
}