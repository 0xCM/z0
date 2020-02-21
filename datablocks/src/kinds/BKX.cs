//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BKX
    {
        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this ClosedBlockKind k)
            => k != 0;

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNone(this ClosedBlockKind k)
            => k == 0;

        /// <summary>
        /// Determines whether the unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit IsUnsigned(this ClosedBlockKind k)
            => ((uint)k & (uint)NumericKind.Unsigned) != 0;

        /// <summary>
        /// Determines whether the signed facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit IsSigned(this ClosedBlockKind k)
            => ((uint)k & (uint)NumericKind.Signed) != 0;

        /// <summary>
        /// Determines whether the floating facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit IsFloat(this ClosedBlockKind k)
            => ((uint)k & (uint)NumericKind.Float) != 0;

        /// <summary>
        /// Determines whether the signed or unsigned facet of a block classification is enabled
        /// </summary>
        /// <param name="k">The vector classifier</param>
        [MethodImpl(Inline)]
        public static bit IsIntegral(this ClosedBlockKind k)
            => k.IsSigned() || k.IsUnsigned();

        public static string Format(this ClosedBlockKind k)
            => k.IsSome() ? k.ToString() : string.Empty;
    }
}