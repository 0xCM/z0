//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static partial class BlockExtend    
    {
        static N8 n8 => default;

        static N16 n16 => default;

        static N32 n32 => default;

        static N64 n64 => default;

        static N128 n128 => default;

        static N256 n256 => default;

        /// <summary>
        /// Presents an unsized span as one of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static NatSpan<N,T> NatLoad<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan.load(src,n);
    }
}
