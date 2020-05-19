//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed; 
    using static Memories;

    partial class gmath
    {
        /// <summary>
        /// Defines the operator eqz:T = eq(a,b) ? ones[T] : zero[T]
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Eqz, Closures(AllNumeric)]
        public static T eqz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.eq(a,b)),ones<T>()); 

        /// <summary>
        /// Defines the operator ltz:T = lt(a,b) ? ones[T] : zero[T]
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Ltz, Closures(AllNumeric)]
        public static T ltz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.lt(a,b)), ones<T>());

        /// <summary>
        /// Defines the operator gtz:T = gt(a,b) ? ones[T] : zero[T]
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Gtz, Closures(AllNumeric)]
        public static T gtz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gt(a,b)), ones<T>());
    }
}