//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// Returns the length of equal-length blocks; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]
        public static int length<S,T>(in SpanBlock128<S> lhs, in SpanBlock128<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : sys.@throw<int>(AppErrors.LengthMismatch(lhs.CellCount, rhs.CellCount));

        /// <summary>
        /// Returns the length of equal-length blocks; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]
        public static int length<S,T>(in SpanBlock256<S> lhs, in SpanBlock256<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : sys.@throw<int>(AppErrors.LengthMismatch(lhs.CellCount, rhs.CellCount));

        /// <summary>
        /// Returns the length of equal-length blocks; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        [MethodImpl(Inline)]
        public static int length<S,T>(in SpanBlock512<S> lhs, in SpanBlock512<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.CellCount == rhs.CellCount ? lhs.CellCount : sys.@throw<int>(AppErrors.LengthMismatch(lhs.CellCount, rhs.CellCount));
    }
}