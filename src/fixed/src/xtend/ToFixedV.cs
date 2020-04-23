//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Fixed128V ToFixedV<T>(this Vector128<T> x)
            where T : unmanaged
                => Fixed128V.From(x);

        [MethodImpl(Inline)]
        public static Fixed256V ToFixedV<T>(this Vector256<T> x)
            where T : unmanaged
                => Fixed256V.From(x);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128V ToFixedV<T>(this Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => Fixed.vfix(f);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp128V ToFixedV<T>(this Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => Fixed.vfix(f);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp256V ToFixedV<T>(this Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => Fixed.vfix(f);
 
        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp256V ToFixedV<T>(this Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => Fixed.vfix(f);
    }
}