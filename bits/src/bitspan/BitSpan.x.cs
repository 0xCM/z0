//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class BitSpanX
    {
        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> ToBitSpan<N,T>(this ReadOnlySpan<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitSpan.load(src,n);

        /// <summary>
        /// Constructs a bitvector of natural length from a source span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal segment type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> ToBitSpan<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitSpan.load(src,n);

        /// <summary>
        /// Converts the least significant elements of a generic natural bitvector to a 8-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector8 ToBitVector<N,T>(this BitSpan<N,T> src, N8 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt8();

        /// <summary>
        /// Converts the least significant elements of a generic natural bitvector to a 16-bit primal bitvector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal source type</typeparam>        
        [MethodImpl(Inline)]
        public static BitVector16 ToBitVector<N,T>(this BitSpan<N,T> src, N16 n)        
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => src.Data.TakeUInt16();

        [MethodImpl(Inline)]
        public static BitSpan<T> Unsize<N,T>(this BitSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitSpan.load(src.Data, natval<N>()); 

        /// <summary>
        /// Extracts the represented data as a bitstring
        /// </summary>
        [MethodImpl(Inline)]
        public static BitString ToBitString<N,T>(this BitSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BitString.scalars(src.Data, src.Width); 

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BitSpan<N,T> src, bool tlz = false, bool specifier = false, int? blockWidth = null)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.ToBitString().Format(tlz, specifier, blockWidth);
    }
}