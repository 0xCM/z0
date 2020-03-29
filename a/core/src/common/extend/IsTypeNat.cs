//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    using static Components;

    partial class XTend
    {
        /// <summary>
        /// Determines whether a type encodes a natural number
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsTypeNat(this Type t)
            => t.Realizes<ITypeNat>();

        /// <summary>
        /// For a type that encodes a natural number, returns the corresponding value; otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ulong> NatValue(this Type t)
            => t.IsTypeNat() ? ((ITypeNat)Activator.CreateInstance(t)).NatValue : default;
    }
}