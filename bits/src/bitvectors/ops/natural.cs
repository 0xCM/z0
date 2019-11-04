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

    public static partial class BitVector
    {

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



    }

}