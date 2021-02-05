//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static CellDelegates;
    using static Cells;

    partial struct gcells
    {
        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryOp16 cellop16<T>(Func<T,T> f)
            where T : unmanaged
                => (Cell16 a) => cell16(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryOp16 cellop16<T>(Func<T,T,T> f)
            where T : unmanaged
                => (Cell16 a, Cell16 b) => cell16(f(a.As<T>(),b.As<T>()));
    }
}