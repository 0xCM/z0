//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Applies to a generic type/method to advertise the types over which type parameter(s) may be closed
    /// </summary>
    public class FixedClosuresAttribute : TypeClosuresAttribute
    {
        public FixedClosuresAttribute(DataWidth width)
            : base((ulong)width)
        {
            this.Width = width;
        }

        public DataWidth Width {get;}
    }
}