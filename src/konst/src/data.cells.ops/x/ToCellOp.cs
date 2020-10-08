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

    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static Cell8 ToCell(this byte x)
            => x;

        [MethodImpl(Inline)]
        public static Cell8 ToCell(this sbyte x)
            => x;

        [MethodImpl(Inline)]
        public static Cell16 ToCell(this short x)
            => x;

        [MethodImpl(Inline)]
        public static Cell16 ToCell(this ushort x)
            => x;

        [MethodImpl(Inline)]
        public static Cell32 ToCell(this int x)
            => x;

        [MethodImpl(Inline)]
        public static Cell32 ToCell(this uint x)
            => x;

        [MethodImpl(Inline)]
        public static Cell64 ToCell(this long x)
            => x;

        [MethodImpl(Inline)]
        public static Cell64 ToCell(this ulong x)
            => x;

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 ToCellOp<T>(this Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => CellOps.unary(f);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 ToCellOp<T>(this Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => CellOps.unary(f);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 ToCellOp<T>(this Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => CellOps.unary(f);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 ToCellOp<T>(this Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => CellOps.unary(f);
    }
}