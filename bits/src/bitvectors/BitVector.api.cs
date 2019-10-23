//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    


    public static class BitVector
    {   
        /// <summary>
        /// Allocates a generic bitvector
        /// </summary>
        /// <param name="init">The value with which the vector is initialized</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Generic<T>(T init)
            where T : unmanaged
                => init;

        [MethodImpl(Inline)]
        public static BitVector<T> Generic<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Allocates a primal 8-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector8 Alloc(N8 n)
            => BitVector8.Alloc();

        /// <summary>
        /// Allocates a primal 16-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector16 Alloc(N16 n)
            => BitVector16.Alloc();

        /// <summary>
        /// Allocates a primal 32-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector32 Alloc(N32 n)
            => BitVector32.Alloc();

        /// <summary>
        /// Allocates a primal 64-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector64 Alloc(N64 n)
            => BitVector64.Alloc();

        /// <summary>
        /// Allocates a generic bitvector of natural length
        /// </summary>
        /// <param name="len">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Alloc<N,T>(N len = default, T? fill = null)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N,T>.Alloc(fill);
            
        /// <summary>
        /// Loads a bitvector of natural length from a span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromCells(src);

        [MethodImpl(Inline)]
        public static BitVector<N,T> Define<N,T>(params T[] src)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromCells(src);

        /// <summary>
        /// Loads a bitvector of natural length from a primal span
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromCells(src.ToSpan());

        /// <summary>
        /// Loads a bitvector of natural length from an array
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> Load<N,T>(T[] src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromCells(src);
 
        /// <summary>
        /// Computes the number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="n">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int CellCount<N,T>(N n = default)
            where T : unmanaged
            where N : ITypeNat, new()
                => BitVector<N,T>.MinCellCount;
    }
}