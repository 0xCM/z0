//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial class Delegates
    {

        /// <summary>
        /// Characterizes a receiver that accepts a stream
        /// </summary>
        /// <typeparam name="T">The stream element type</typeparam>
        [Free]
        public delegate void StreamReceiver<T>(IEnumerable<T> src);

        /// <summary>
        /// Characterizes a receiver that accepts a span
        /// </summary>
        /// <typeparam name="T">The stream element type</typeparam>
        [Free]
        public delegate void SpanReceiver<T>(Span<T> src);

        [Free]
        public delegate bool TernaryPredicate<W,T>(T a, T b, T c)
            where W : unmanaged, ITypeWidth;
    }
}