//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    /// <summary>
    /// Applies to a generic type/method to advertise the types over which type parameter(s) may be closed
    /// </summary>
    public class NumericClosuresAttribute : TypeClosuresAttribute
    {
        public NumericClosuresAttribute(NumericKind nk)
            : base((ulong)nk)
        {
            this.NumericPrimitive = nk;
        }

        public NumericKind NumericPrimitive {get;}
    }
}