//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representativev</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static ulong value<N>(N n = default)
            where N : unmanaged, ITypeNat
                => TypeNats.value(n);

        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representativev</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static byte val8u<N>(N n = default)
            where N : unmanaged, ITypeNat
                => (byte)TypeNats.value(n);
    }
}