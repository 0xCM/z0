//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static root;
    using static Stacked;
    using static P2K;

    partial class Stacks
    {
        /// <summary>
        /// Counts the number of T-cells convered by a n-bit stack
        /// </summary>
        /// <param name="n">The stack storage size in bits</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int count<T>(P2x6 n, T t = default)
            => MemStack64.Size/Unsafe.SizeOf<T>();

        /// <summary>
        /// Counts the number of T-cells convered by a n-bit stack
        /// </summary>
        /// <param name="n">The stack storage size in bits</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int count<T>(P2x7 n, T t = default)
            => MemStack128.Size/Unsafe.SizeOf<T>();

        /// <summary>
        /// Counts the number of T-cells convered by a n-bit stack
        /// </summary>
        /// <param name="n">The stack storage size in bits</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int count<T>(P2x8 n, T t = default)
            => MemStack256.Size/Unsafe.SizeOf<T>();

        /// <summary>
        /// Counts the number of T-cells convered by a n-bit stack
        /// </summary>
        /// <param name="n">The stack storage size in bits</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int count<T>(P2x9 n, T t = default)
            => MemStack512.Size/Unsafe.SizeOf<T>();

        /// <summary>
        /// Counts the number of T-cells convered by a n-bit stack
        /// </summary>
        /// <param name="n">The stack storage size in bits</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static int count<T>(P2x10 n, T t = default)
            => MemStack1024.Size/Unsafe.SizeOf<T>();
    }

}