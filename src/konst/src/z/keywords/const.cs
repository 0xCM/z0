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
        /// Captures a sized readonly parametric reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The cell count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ConstRef<T> @const<T>(in T src, uint count)
            => new ConstRef<T>(seg(pvoid(src), size<T>(count)));

        /// <summary>
        /// Captures a sized readonly parametric reference to source span content
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe ConstRef<T> @cost<T>(ReadOnlySpan<T> src)
            => new ConstRef<T>(seg(pvoid(first(src)), size<T>((uint)src.Length)));

        /// <summary>
        /// Captures a readonly character reference to source string content
        /// </summary>
        /// <param name="src">The source string</param>
        [MethodImpl(Inline), Op]
        public static unsafe ConstRef<char> @const(string src)
            => new ConstRef<char>(new Ref(address(src), (uint)src.Length*2));
    }
}