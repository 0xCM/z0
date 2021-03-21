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
        /// Creates a fixed 8-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.Emitter8 cellop8<T>(Func<T> f)
            where T : unmanaged
                => () => cell8(f());

        /// <summary>
        /// Creates a fixed 8-bit unary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.UnaryOp8 cellop8<T>(Func<T,T> f)
            where T : unmanaged
                => (Cell8 a) => cell8(f(a.As<T>()));

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied delegate
        /// </summary>
        /// <param name="f">The source delegate</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static D.BinaryOp8 cellop8<T>(Func<T,T,T> f)
            where T : unmanaged
                => (Cell8 a, Cell8 b) => cell8(f(a.As<T>(),b.As<T>()));
    }
}