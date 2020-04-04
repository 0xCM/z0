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
        /// Determines the width of a (known) segmented type
        /// </summary>
        /// <param name="src">The source type</param>
        public static TypeWidth segmented(Type src)
            => src.Tag<SegmentedAttribute>().MapValueOrElse(a => a.TypeWidth, () => vector(src));
    }
}