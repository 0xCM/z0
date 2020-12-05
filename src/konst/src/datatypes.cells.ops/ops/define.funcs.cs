//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Cells;
    using static CellDelegates;

    partial struct CellOps
    {
        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp8 define<T>(Func<T,T> f, U8 dst)
            where T : unmanaged
                => (Cell8 a) => c8(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp16 define<T>(Func<T,T> f, U16 dst)
            where T : unmanaged
                => (Cell16 a) => c16(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp32 define<T>(Func<T,T> f, U32 dst)
            where T : unmanaged
                => (Cell32 a) => c32(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp64 define<T>(Func<T,T> f, U64 dst)
            where T : unmanaged
                => (Cell64 a) => c64(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp8 define<T>(Func<T,T,T> f, U8 dst)
            where T : unmanaged
                => (Cell8 a, Cell8 b) => c8(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp16 define<T>(Func<T,T,T> f, U16 dst)
            where T : unmanaged
                => (Cell16 a, Cell16 b) => c16(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp32 define<T>(Func<T,T,T> f, U32 dst)
            where T : unmanaged
                => (Cell32 a, Cell32 b) => c32(f(a.As<T>(),b.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp64 define<T>(Func<T,T,T> f, U64 dst)
            where T : unmanaged
                => (Cell64 a, Cell64 b) => c64(f(a.As<T>(),b.As<T>()));
    }
}