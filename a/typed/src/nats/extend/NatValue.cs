//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// For a type that encodes a natural number, returns the corresponding value; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ulong> NatValue(this Type t)
            => t.IsTypeNat() ? ((ITypeNat)Activator.CreateInstance(t)).NatValue : default;
    }
}