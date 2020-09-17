//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericKinds;

    partial class CellOps
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell8 F8<T>(T src)
            where T : unmanaged
                => Cell8.From(Cast.to<T,byte>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell16 F16<T>(T src)
            where T : unmanaged
                => Cell16.From(Cast.to<T,ushort>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell32 F32<T>(T src)
            where T : unmanaged
                => Cell32.init(Cast.to<T,uint>(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Cell64 F64<T>(T src)
            where T : unmanaged
                => Cell64.From(Cast.to<T,ulong>(src));

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static UnaryOp8 fix<T>(Func<T,T> f, U8 dst)
            where T : unmanaged
                => (Cell8 a) => F8(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static UnaryOp16 fix<T>(Func<T,T> f, U16 dst)
            where T : unmanaged
                => (Cell16 a) => F16(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static UnaryOp32 fix<T>(Func<T,T> f, U32 dst)
            where T : unmanaged
                => (Cell32 a) => F32(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static UnaryOp64 fix<T>(Func<T,T> f, U64 dst)
            where T : unmanaged
                => (Cell64 a) => F64(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryOp8 fix<T>(Func<T,T,T> f, U8 dst)
            where T : unmanaged
                => (Cell8 a, Cell8 b) => F8(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryOp16 fix<T>(Func<T,T,T> f, U16 dst)
            where T : unmanaged
                => (Cell16 a, Cell16 b) => F16(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryOp32 fix<T>(Func<T,T,T> f, U32 dst)
            where T : unmanaged
                => (Cell32 a, Cell32 b) => F32(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryOp64 fix<T>(Func<T,T,T> f, U64 dst)
            where T : unmanaged
                => (Cell64 a, Cell64 b) => F64(f(a.As<T>(),b.As<T>()));
    }
}