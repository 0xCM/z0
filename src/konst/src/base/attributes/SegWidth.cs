//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class SegWidthAttribute : Attribute
    {
        public SegWidthAttribute(string description)
        {
            Description = description;
        }

        public string Description {get;}            
    }  
}