//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Konst;
    using static Kinds;

    partial class CellOps
    {
        [MethodImpl(Inline), Op]
        public static UnaryOp1 unary(UnaryOp<bit> f)
            => a => f(a);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 unary(UnaryOp<sbyte> f)
            => a => f((sbyte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp8 unary(UnaryOp<byte> f)
            => a => f((byte)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 unary(UnaryOp<short> f)
            => a => f((short)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp16 unary(UnaryOp<ushort> f)
            => a => f((ushort)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 unary(UnaryOp<int> f)
            => a => f((int)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp32 unary(UnaryOp<uint> f)
            => a => f((uint)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 unary(UnaryOp<long> f)
            => a => f((long)a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp64 unary(UnaryOp<ulong> f)
            => a => f(a.Content);

        [MethodImpl(Inline), Op]
        public static UnaryOp1 unary(MethodInfo f, UnaryOpClass<bit> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 unary(MethodInfo f, UnaryOpClass<sbyte> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp8 unary(MethodInfo f, UnaryOpClass<byte> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 unary(MethodInfo f, UnaryOpClass<short> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp16 unary(MethodInfo f, UnaryOpClass<ushort> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 unary(MethodInfo f, UnaryOpClass<uint> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp32 unary(MethodInfo f, UnaryOpClass<int> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 unary(MethodInfo f, UnaryOpClass<ulong> k)
            => unary(uFx(f,k));

        [MethodImpl(Inline), Op]
        public static UnaryOp64 unary(MethodInfo f, UnaryOpClass<long> k )
            => unary(uFx(f,k));

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UnaryOp128 unary<T>(Func<Vector128<T>, Vector128<T>> f)
            where T : unmanaged
                => (Cell128 a) => f(a.ToVector<T>()).ToCell();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UnaryOp256 unary<T>(Func<Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Cell256 a) => f(a.ToVector<T>()).ToCell();

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinaryOp128 unary<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f)
            where T : unmanaged
                => (Cell128 a, Cell128 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToCell();

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinaryOp256 unary<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f)
            where T : unmanaged
                => (Cell256 a, Cell256 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToCell();
    }
}