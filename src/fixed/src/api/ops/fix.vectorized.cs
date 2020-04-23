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

    partial class Fixed
    {        
        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128V vfix<T>(Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => (Fixed128V a) => f(a.ToVector<T>()).ToFixedV();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp256V vfix<T>(Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Fixed256V a) => f(a.ToVector<T>()).ToFixedV();  

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp128V vfix<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => (Fixed128V a, Fixed128V b) => f(a.ToVector<T>(),b.ToVector<T>()).ToFixedV();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp256V vfix<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Fixed256V a, Fixed256V b) => f(a.ToVector<T>(),b.ToVector<T>()).ToFixedV();          
    }
}