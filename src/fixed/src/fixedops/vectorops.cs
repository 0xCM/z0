//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    partial class FixedOps
    {
        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UnaryOp128 vfix<T>(Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => (FixedCell128 a) => f(a.ToVector<T>()).ToFixed();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UnaryOp256 vfix<T>(Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (FixedCell256 a) => f(a.ToVector<T>()).ToFixed();

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinaryOp128 vfix<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => (FixedCell128 a, FixedCell128 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinaryOp256 vfix<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (FixedCell256 a, FixedCell256 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();
    }
}