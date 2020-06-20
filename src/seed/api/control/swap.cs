//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        /// <summary>
        /// Interchanges span elements i and j
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="i">An index of a span element</param>
        /// <param name="j">An index of a span element</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void swap<T>(Span<T> src, int i, int j)
            where T : unmanaged
        {
            if(i==j)
                return;
            
            ref var data = ref head(src);
            var a = seek(ref data, i);
            seek(ref data, i) = skip(in data, j);
            seek(ref data, j) = a;
        }
    }
}