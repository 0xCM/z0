//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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

    partial class BitVector
    {


        /// <summary>
        /// Allocates a 4-bit primal bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector4 alloc(N4 n)
            => default;

        /// <summary>
        /// Allocates an 8-bit primal bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector8 alloc(N8 n)
            => default;

        /// <summary>
        /// Allocates a primal 16-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector16 alloc(N16 n)
            => default;

        /// <summary>
        /// Allocates a primal 32-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector32 alloc(N32 n)
            => default;

        /// <summary>
        /// Allocates a primal 64-bit bitvector
        /// </summary>
        /// <param name="n">The width discriminator</param>
        [MethodImpl(Inline)]
        public static BitVector64 alloc(N64 n)
            => default;

        /// <summary>
        /// Allocates a generic bitvector
        /// </summary>
        /// <param name="n">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> alloc<T>(T fill = default)
            where T : unmanaged
                => BitVector.generic(fill);

        /// <summary>
        /// Allocates a natural bitvector
        /// </summary>
        /// <param name="n">The number of bits to store</param>
        /// <typeparam name="T">The primal storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> alloc<N,T>(N n = default, T fill = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => new BitVector<N, T>(fill);

    }
}