//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines an unweighted edge, parameterized by the vertex index type
    /// </summary>
    /// <typeparam name="T">The vertex index type</typeparam>
    public readonly struct Edge<T>
        where T : unmanaged
    {
        /// <summary>
        /// The index of the source vertex
        /// </summary>
        public readonly T Source;

        /// <summary>
        /// The index of the target vertex
        /// </summary>
        public readonly T Target;

        [MethodImpl(Inline)]
        public static implicit operator (T src, T dst)(Edge<T> edge)
            => (edge.Source,edge.Target);

        [MethodImpl(Inline)]
        public static implicit operator Edge<T>((T src, T dst) x)
            => (x.src,x.dst);

        [MethodImpl(Inline)]
        public Edge(T src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public string Format()
            => $"{Source} -> {Target}";

        public override string ToString()
            => Format();
    }
}