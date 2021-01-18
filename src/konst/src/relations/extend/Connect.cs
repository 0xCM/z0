//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        /// <summary>
        /// Produces an edge that connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="T">The vertex payload type</typeparam>
        [MethodImpl(Inline)]
        public static Link<V> Connect<V,T>(this Node<V,T> src, Node<V,T> dst)
            where V : unmanaged
            where T : unmanaged
                => Links.connect(src,dst);

        /// <summary>
        /// Produces an edge that connects a source vertex to a target vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        /// <param name="dst">The target vertex</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        [MethodImpl(Inline)]
        public static Link<V> Connect<V>(this Node<V> src, Node<V> dst)
            where V : unmanaged
                => Links.connect(src,dst);
    }
}