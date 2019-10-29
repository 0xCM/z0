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
    using static nfunc;

    public static partial class BitVector
    {
        /// <summary>
        /// Allocates a generic empty bitvector
        /// </summary>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> generic<T>()
            where T : unmanaged
                => default;

        /// <summary>
        /// Allocates a generic bitvector initialized with a specified value
        /// </summary>
        /// <param name="init">The value with which the vector is initialized</param>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> generic<T>(T init)
            where T : unmanaged
                => init;

        /// <summary>
        /// Defines a natural generic bitvector, either tmpty or filled with an optional value if specified
        /// </summary>
        /// <param name="n">The natural length of the vector in bits</param>
        /// <param name="fill">The optional fill value</param>
        /// <typeparam name="N">The natural type upon which the vector is predicated</typeparam>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(N len = default, T? fill = null)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N,T>.Alloc(fill);

        /// <summary>
        /// Defines a natural generic bitvector, initialized with a parameter array for which
        /// the total bit width is at least the value defined by the natural parameter
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="N">The natural type upon which the vector is predicated</typeparam>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(params T[] src)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromArray(src);

        /// <summary>
        /// Defines a natural generic bitvector, initialized with an array for which
        /// the total bit width is at least the value defined by the natural parameter
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="n">The natural length of the vector in bits</param>
        /// <typeparam name="N">The natural type upon which the vector is predicated</typeparam>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(T[] src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromArray(src);

        /// <summary>
        /// Computes the minimum number of cells required to hold a specified number of bits
        /// </summary>
        /// <param name="n">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static int mincells<N,T>(N n = default)
            where T : unmanaged
            where N : ITypeNat, new()
                => BitVector<N,T>.MinCellCount;

        /// <summary>
        /// Defines a natural generic bitvector, initialized with a readonly span for which
        /// the total bit width is at least the value defined by the natural parameter
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="N">The natural type upon which the vector is predicated</typeparam>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(ReadOnlySpan<T> src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromSpan(src.ToSpan());

        /// <summary>
        /// Defines a natural generic bitvector, initialized with a span for which
        /// the total bit width is at least the value defined by the natural parameter
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <typeparam name="N">The natural type upon which the vector is predicated</typeparam>
        /// <typeparam name="T">The primal type upon which the vector is predicated</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> natural<N,T>(Span<T> src, N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N, T>.FromSpan(src);

        /// <summary>
        /// Allocates a primal 8-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector8 alloc(N8 n)
            => BitVector8.Alloc();

        /// <summary>
        /// Allocates a primal 16-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector16 alloc(N16 n)
            => BitVector16.Alloc();

        /// <summary>
        /// Allocates a primal 32-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector32 alloc(N32 n)
            => BitVector32.Alloc();

        /// <summary>
        /// Allocates a primal 64-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector64 alloc(N64 n)
            => BitVector64.Alloc();




    }

}