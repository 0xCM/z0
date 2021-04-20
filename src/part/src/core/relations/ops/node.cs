//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Relations
    {
        /// <summary>
        /// Creates a vertex with payload
        /// </summary>
        /// <param name="index">The index of the vertex that servies as a
        /// unique identifier within the context of a graph</param>
        /// <typeparam name="V">The index type</typeparam>
        /// <typeparam name="V">The payload type</typeparam>
        [MethodImpl(Inline)]
        public static Node<V,T> node<V,T>(V index, T data)
            where V : unmanaged
            where T : unmanaged
                => new Node<V,T>(index,data);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Node<T> node<T>(T src)
            => new Node<T>(src);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static TypeNode<T> node<T>()
            => default;
    }
}