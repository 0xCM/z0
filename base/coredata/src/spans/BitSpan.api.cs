    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines bitspan api surface
    /// </summary>
    public static class BitSpan
    {
        [MethodImpl(NotInline)]
        public static BitSpan<T> from<T>(Span<T> src)
            where T : unmanaged
        {
            var bits = src.Length * Unsafe.SizeOf<T>() * 8;

            if(bits % 64 != 0)
                throw new NotSupportedException($"{bits} (bits) is not a muliple of 64");
            return new BitSpan<T>(src);
        }

        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(ref T src, N n = default)        
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
            =>  new BitSpan<N, T>(MemoryMarshal.CreateSpan(ref src, cells<N,T>()));

        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(in Span64<T> src, N n = default)
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
            where T : unmanaged
                => new BitSpan<N, T>(src.Unblocked);
    
        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(in Span128<T> src, N n = default)
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
            where T : unmanaged
                => new BitSpan<N, T>(src.Unblocked);

        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(in Span256<T> src)
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
            where T : unmanaged
                => new BitSpan<N, T>(src.Unblocked);

        /// <summary>
        /// Computes the number of T-cells are required to store N bits where N >= 64 and N % 64 = 0
        /// </summary>
        /// <param name="n">The bit count representative</param>
        /// <param name="zero">The cell type representative</param>
        /// <typeparam name="N">The bit count type</typeparam>
        /// <typeparam name="T">The cell count type</typeparam>
        public static int cells<N,T>(N n = default, T zero = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
                => (Unsafe.SizeOf<T>()*8) / natval<N>();         
    }
}