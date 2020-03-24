//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public static class FixedWidthOps
    {
        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this FixedWidth src)
            => src != 0;

        /// <summary>
        /// Determines whether the kind is zero-valued
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static bool IsNone(this FixedWidth src)
            => src == 0;

        /// <summary>
        /// Produces a canonical text representation of the source kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static string Format(this FixedWidth src)
            => $"{(int)src}";
    }    
}