//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using D = CellDelegates;

    partial struct gcells
    {
        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.UnaryOp32 cellop32<T>(Func<T,T> f)
            where T : unmanaged
                => (Cell32 a) => cell32(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.BinaryOp32 cellop32<T>(Func<T,T,T> f)
            where T : unmanaged
                => (Cell32 a, Cell32 b) => cell32(f(a.As<T>(), b.As<T>()));
    }
}