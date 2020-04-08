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
        /// Retrieves the value of a type natural represented as a signed integer
        /// </summary>
        /// <typeparam name="N">The nat type</typeparam>
        [MethodImpl(Inline)]   
        public static int nati<N>(N n = default) 
            where N : unmanaged, ITypeNat
                => (int)value<N>();

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

        /// <summary>
        /// Counts the number of numeric T-cells that can be convered by contiguous memory of width W
        /// </summary>
        /// <param name="w">The memory bit-width</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int cells<W,T>(W w = default, T t = default)
            where W : unmanaged, ITypeWidth
            where T : unmanaged
                => Widths.cells<W,T>();

    }
}