//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Components;
    using static TypeWidths;

    public static class BlockedType
    {
        static BlockedAttribute tag(Type t)
            => (BlockedAttribute)t.EffectiveType().GetCustomAttribute(typeof(BlockedAttribute));
        
        /// <summary>
        /// Determines whether a type is block-classified
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
            => tag(t) != null;

        public static FixedWidth width(Type src)
            => tag(src)?.TotalWdth ?? FixedWidth.None;

        /// <summary>
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static NumericKind segment(Type t)
            => test(t) ?  t.SuppliedTypeArgs().First().NumericKind() : NumericKind.None;
    }
}