//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class root
    {            
        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(ReadOnlySpan<T> first, ReadOnlySpan<T> second, Action<T,T> f)
            => Spans.iter(first,second,f);

        /// <summary>
        /// Inovkes an action for each pair of elements in source spans of equal length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The receiver</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void iter<T>(Span<T> first, Span<T> second, Action<T,T> f)
            => Spans.iter(first,second,f);
    }
}