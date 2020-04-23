//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class Widths
    {        
        /// <summary>
        /// Determines the attributed width of a blocked type
        /// </summary>
        /// <param name="src">The source type</param>        
        public static TypeWidth blocked(Type src)
            => src.Tag<BlockedAttribute>().MapValueOrDefault(a => a.TypeWidth, TypeWidth.None);
    }
}