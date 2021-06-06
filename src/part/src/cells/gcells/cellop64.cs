//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using D = CellDelegates;

    partial struct gcells
    {
        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.UnaryOp64 cellop64<T>(Func<T,T> f)
            where T : unmanaged
                => (Cell64 a) => cell64(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.BinaryOp64 cellop64<T>(Func<T,T,T> f)
            where T : unmanaged
                => (Cell64 a, Cell64 b) => cell64(f(a.As<T>(), b.As<T>()));
    }
}