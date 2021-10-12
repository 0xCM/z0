//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial struct cpu
    {
        /// <summary>
        /// Computes v[i] = |a[i] - b[i]|
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [MethodImpl(Inline), Abs]
        public static Vector128<byte> vabsdelta(Vector128<byte> a, Vector128<byte> b)
            => vor(vsubs(a, b), vsubs(b, a));

        /// <summary>
        /// Computes v[i] = |a[i] - b[i]|
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [MethodImpl(Inline), Abs]
        public static Vector128<ushort> vabsdelta(Vector128<ushort> a, Vector128<ushort> b)
            => vor(vsubs(a, b), vsubs(b, a));

        /// <summary>
        /// Computes v[i] = |a[i] - b[i]|
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [MethodImpl(Inline), Abs]
        public static Vector256<byte> vabsdelta(Vector256<byte> a, Vector256<byte> b)
            => vor(vsubs(a, b), vsubs(b, a));

        /// <summary>
        /// Computes v[i] = |a[i] - b[i]|
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        [MethodImpl(Inline), Abs]
        public static Vector256<ushort> vabsdelta(Vector256<ushort> a, Vector256<ushort> b)
            => vor(vsubs(a, b), vsubs(b, a));
    }
}