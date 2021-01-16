//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;


    public static partial class XTend
    {
        /// Determines whether the unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline), Op]
        public static bool IsUnsigned(this SegBlockKind k)
            => ((uint)k & (uint)Z0.NumericKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether the signed facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline), Op]
        public static bool IsSigned(this SegBlockKind k)
            => ((uint)k & (uint)Z0.NumericKind.Signed) != 0;

        /// <summary>
        /// Determines whether the signed or unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline), Op]
        public static bool IsIntegral(this SegBlockKind k)
            => k.IsSigned() || k.IsUnsigned();

        /// <summary>
        /// Determines whether the floating facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline), Op]
        public static bool IsFloat(this SegBlockKind k)
            => ((uint)k & (uint)Z0.NumericKind.Float) != 0;
    }
}