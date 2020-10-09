//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Determines whether the floating facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Konst.Inline)]
        public static bool IsFloat(this SegBlockKind k)
            => ((uint)k & (uint)Z0.NumericKind.Float) != 0;
    }
}