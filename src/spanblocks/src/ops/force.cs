//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Typed;

    partial struct SpanBlocks
    {
        /// <summary>
        /// If possible, applies the conversion S -> T for each cell in the source block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static SpanBlock256<T> force<S,T>(SpanBlock256<S> src)
            where T : unmanaged
            where S : unmanaged
        {
            var dst = alloc<T>(w256, (ulong)src.CellCount);
            for(var i=0; i<src.CellCount; i++)
                dst[i] = NumericCast.force<S,T>(src[i]);
            return dst;
        }
    }
}