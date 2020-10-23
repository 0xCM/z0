//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct PermSymbolic
    {
        /// <summary>
        /// Applies a transposition sequence to an input sequence
        /// </summary>
        /// <param name="src">The input sequence</param>
        /// <param name="swaps">The transposition sequence</param>
        /// <param name="dst">The output sequence</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void apply<T>(ReadOnlySpan<T> src, ReadOnlySpan<Swap> swaps, Span<T> dst)
            where T : unmanaged
        {
            var len = swaps.Length;
            ref readonly var input = ref first(src);
            ref readonly var exchange = ref first(swaps);
            for(var k = 0u; k<len; k++)
            {
                ref readonly var x = ref skip(exchange, k);
                swap(ref seek(input, x.i), ref seek(input, x.j));
            }
        }
    }
}