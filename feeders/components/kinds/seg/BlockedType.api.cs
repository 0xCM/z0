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
        /// <summary>
        /// Determines whether a type is block-classified
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool test(Type t)
            => Attribute.IsDefined(t,typeof(BlockedAttribute));        

        public static FixedWidth width(Type src)
        {
            var attrib = (BlockedAttribute)src.GetCustomAttribute(typeof(BlockedAttribute));
            return attrib?.TotalWdth ?? FixedWidth.None;
        }


        /// <summary>
        /// Determines the segment kind classifier for a blocked type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static NumericKind segment(Type t)
            => test(t) ?  t.SuppliedTypeArgs().First().NumericKind() : NumericKind.None;



    }
}