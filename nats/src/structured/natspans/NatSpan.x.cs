//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Components;
    using static nfunc;

    public static class NatSpanX
    {
        public static NatSpan<N,T> Contract<N,T>(this NatSpan<N,T> src, NatSpan<N,T> max)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = NatSpan.alloc<N, T>();
            for(var i=0; i<dst.Length; i++)
                dst[i] = Numeric.contract(src[i],max[i]);
            return dst;
        }

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
 
        /// <summary>
        /// Formats a span of natural length and integral type as a sequence of hex values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bracket">Whether to enclose the formatted hex within brackets</param>
        /// <param name="sep">The character to use when separating digits</param>
        /// <param name="specifier">Whether to prefix each number with the canonical hex specifier, "0x"</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatHex<N,T>(this NatSpan<N,T> src, bool bracket = false, char? sep = null, bool specifier = false)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.FormatHex(bracket, sep, specifier);

        /// <summary>
        /// Formats a span of natural length as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        public static string FormatList<N,T>(this NatSpan<N,T> src, char delimiter = ',', int offset = 0, int pad = 0, bool bracketed = true)
            where N : unmanaged, ITypeNat
            where T : unmanaged 
                => src.Data.FormatDataList(delimiter,offset,pad,bracketed);
    }
}