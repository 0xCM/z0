//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Core
    {
        /// <summary>
        /// Constructs a span from a parameter array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<T>(params T[] src)
            => src;
    }
}