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
    using static nfunc;


    public static class NatSpanX
    {
        [MethodImpl(Inline)]
        public static void Fill<N,T>(this in NatSpan<N,T> dst, T data)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan.broadcast(data, dst);

        [MethodImpl(Inline)]
        public static Span<T> Slice<N,T>(this in NatSpan<N,T> src, int offset)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Slice(offset);

        [MethodImpl(Inline)]
        public static Span<T> Slice<N,T>(this in NatSpan<N,T> src, int offset, int length)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.Slice(offset, length);

        /// <summary>
        /// Clones a natural span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,T> Replicate<N,T>(this in NatSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> dst = new T[natval<N>()];
            src.CopyTo(dst);
            return new NatSpan<N,T>(dst);
        }

       [MethodImpl(Inline)]
        public static void CopyTo<N,T>(this in NatSpan<N,T> src,Span<T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.CopyTo(dst);
 
    }

}