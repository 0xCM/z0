//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    public static partial class RootX
    {
        /// <summary>
        /// Converts a fixed width kind to an integer corresponding to the with represented by the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static int ToInteger(this FixedWidth src)
            => (int)src;

        [MethodImpl(Inline)]
        public static string Format(this FixedWidth src)
            => src.ToInteger().ToString();

        /// <summary>
        /// Determines whether kind has a nonzero value
        /// </summary>
        /// <param name="k">The kind to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this FixedWidth src)
            => src != FixedWidth.None;
    }
}