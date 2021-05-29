//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class gmath
    {
        /// <summary>
        /// Defines the operator gtz:T = gt(a,b) ? ones[T] : zero[T]
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Gtz, Closures(Integers)]
        public static T gtz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(NumericCast.force<T>((uint)gt(a,b)), NumericLiterals.ones<T>());
    }
}