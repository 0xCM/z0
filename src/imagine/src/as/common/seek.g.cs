//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsDeprecated
    {
        /// <summary>
        /// Advances an S-reference in units measured by T-cells and returns
        /// the resulting T-cell reference
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of T-cells to advance</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T seek<S,T>(in S src, uint count)
            => ref Add(ref As<S,T>(ref edit(src)), (int)count);
    }
}