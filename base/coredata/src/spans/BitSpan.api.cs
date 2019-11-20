    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines bitspan api surface
    /// </summary>
    public static class BitSpan
    {
        /// <summary>
        /// Creates bitspan from a parameter array
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> load<N,T>(params T[] src)
            where T : unmanaged        
            where N : unmanaged, ITypeNat<N>
                =>  new BitSpan<N, T>(MemoryMarshal.CreateSpan(ref src[0], cells<N,T>()));                

        /// <summary>
        /// Creates bitspan from a parameter array
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitSpan<N,T> load<N,T>(N n, params T[] src)
            where T : unmanaged        
            where N : unmanaged, ITypeNat<N>
                =>  new BitSpan<N, T>(MemoryMarshal.CreateSpan(ref src[0], cells<N,T>()));                

        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(ref T src, N n = default)        
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>
                =>  new BitSpan<N, T>(MemoryMarshal.CreateSpan(ref src, cells<N,T>()));

        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(in Span64<T> src, N n = default)
            where N : unmanaged, ITypeNat<N>
            where T : unmanaged
                => new BitSpan<N, T>(src.Unblocked);
    
        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(in Span128<T> src, N n = default)
            where N : unmanaged, ITypeNat<N>
            where T : unmanaged
                => new BitSpan<N, T>(src.Unblocked);

        [MethodImpl(Inline)]
        public static BitSpan<N,T> from<N,T>(in Span256<T> src, N n = default)
            where N : unmanaged, ITypeNat<N>
            where T : unmanaged
                => new BitSpan<N, T>(src.Unblocked);

        /// <summary>
        /// Allocates a bitspan of width 2^N over cells of primal type
        /// </summary>
        /// <param name="n">The bit width selector</param>
        /// <param name="fill">The cell fill value</param>
        /// <typeparam name="N">The log2 type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(NotInline)]
        public static BitSpan<N,T> alloc<N,T>(N n = default, T fill = default)
            where N : unmanaged, ITypeNat<N>
            where T : unmanaged
        {
            Span<T> dst = new T[cells<N,T>()];
            if(!fill.Equals(default))
                dst.Fill(fill);
            return new BitSpan<N, T>(dst);
        }

        /// <summary>
        /// Computes the number of of bits dtermined by its log2 representative
        /// </summary>
        /// <param name="n">The bit width selector</param>
        /// <typeparam name="N">The bit width log2 type</typeparam>
        [MethodImpl(Inline)]
        public static int bits<N>(N n = default) 
            where N : unmanaged, ITypeNat<N>
                => NatMath.pow2<N>();

        /// <summary>
        /// Computes the aligned number of bytes required to cover 2^n bits
        /// </summary>
        /// <param name="n">The bit width selector</param>
        /// <typeparam name="N">The bit width log2 type</typeparam>
        [MethodImpl(Inline)]
        public static int bytes<N>(N n = default) 
            where N : unmanaged, ITypeNat<N>
                => bits(n) >> 3;

        /// <summary>
        /// Computes the number of T-cells are required to store log2(N) bits
        /// </summary>
        /// <param name="n">The bit count representative</param>
        /// <param name="zero">The cell type representative</param>
        /// <typeparam name="N">The bit count type</typeparam>
        /// <typeparam name="T">The cell count type</typeparam>
        [MethodImpl(Inline)]
        public static int cells<N,T>(N n = default, T zero = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>        
        {
            var bytecount = bytes(n);            
            var cellcount = bytecount / Unsafe.SizeOf<T>();
            return cellcount != 0 ? cellcount : 1;
        }
    }
}