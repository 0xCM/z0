//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace  Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Covers a token-identified buffer with a span
        /// </summary>
        [MethodImpl(Inline)]
        public static unsafe Span<T> Content<T>(this IBufferToken src)
            where T : unmanaged
                => Buffers.content<T>(src);
    }
}