//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Fills a caller-supplied buffer with T-cell bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void deposit<T>(in T src, Span<byte> dst)
            where T : struct
                => @as<byte,T>(ref first(dst)) = src;
    }
}