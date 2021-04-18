//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Arrows
    {
        /// <summary>
        /// Defines an edge from an index-identified source to an index identified target
        /// </summary>
        /// <param name="source">The source index</param>
        /// <param name="target">The target index</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Arrow<T> link<T>(T src, T dst)
            => new Arrow<T>(src,dst);

        /// <summary>
        /// Defines a link from a source to a target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">THe target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Arrow<S,T> link<S,T>(S src, T dst)
            => new Arrow<S,T>(src, dst);

        [MethodImpl(Inline)]
        public static Arrow<S,T,K> link<S,T,K>(S src, T dst, K kind)
            where K : unmanaged
                => new Arrow<S,T,K>(src, dst, kind);
    }
}