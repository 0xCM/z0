//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    public sealed class FixedAttribute : WidthAttribute
    {
        public FixedAttribute(FixedWidth width)
            : base((TypeWidth)width)
        {
        }
    }    
}