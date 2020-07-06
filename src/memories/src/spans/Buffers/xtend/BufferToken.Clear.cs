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
        /// Zero-fills a token-identified buffer
        /// </summary>
        [MethodImpl(Inline)]
        public static void Clear(this IBufferToken src)
            => Buffers.clear(src);
    }
}