//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct memory
    {
        /// <summary>
        /// Subtracts an offset from a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to subtract</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T subtract<T>(in T src, ulong count)
            => ref Subtract(ref edit(src), (int)count);

        /// <summary>
        /// Subtracts an offset from a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The T-cell count to subtract</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T subtract<T>(in T src, long count)
            => ref Subtract(ref edit(src), (int)count);
    }
}