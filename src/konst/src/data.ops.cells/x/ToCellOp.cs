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
        public static BinaryOp8 ToCellOp(this BinaryOp<byte> f)
            => CellOps.cellular(f);

        [MethodImpl(Inline)]
        public static BinaryOp8 ToCellOp(this BinaryOp<sbyte> f)
            => CellOps.cellular(f);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToCellOp(this BinaryOp<short> f)
            => CellOps.cellular(f);

        [MethodImpl(Inline)]
        public static BinaryOp16 ToCellOp(this BinaryOp<ushort> f)
            => CellOps.binary(f);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToCellOp(this BinaryOp<int> f)
            => CellOps.binary(f);

        [MethodImpl(Inline)]
        public static BinaryOp32 ToCellOp(this BinaryOp<uint> f)
            => CellOps.binary(f);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToCellOp(this BinaryOp<long> f)
            => CellOps.binary(f);

        [MethodImpl(Inline)]
        public static BinaryOp64 ToCellOp(this BinaryOp<ulong> f)
            => CellOps.binary(f);

        [MethodImpl(Inline)]
        public static Cell8 ToCellOp(this byte x)
            => x;

        [MethodImpl(Inline)]
        public static Cell8 ToCellOp(this sbyte x)
            => x;

        [MethodImpl(Inline)]
        public static Cell16 ToCellOp(this short x)
            => x;

        [MethodImpl(Inline)]
        public static Cell16 ToCellOp(this ushort x)
            => x;

        [MethodImpl(Inline)]
        public static Cell32 ToCellOp(this int x)
            => x;

        [MethodImpl(Inline)]
        public static Cell32 ToCellOp(this uint x)
            => x;

        [MethodImpl(Inline)]
        public static Cell64 ToCellOp(this long x)
            => x;

        [MethodImpl(Inline)]
        public static Cell64 ToCellOp(this ulong x)
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