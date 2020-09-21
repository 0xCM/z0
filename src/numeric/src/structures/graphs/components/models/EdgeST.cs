//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Edge<S,T>
        where S : unmanaged
        where T : unmanaged
    {

        /// <summary>
        /// The index of the source vertex
        /// </summary>
        public readonly S Source;

        /// <summary>
        /// The index of the target vertex
        /// </summary>
        public readonly T Target;

        /// <summary>
        /// Constructs an edge from a 3-tuple
        /// </summary>
        /// <param name="src">The source index</param>
        /// <param name="dst">The target index</param>
        /// <param name="weight">The weight</param>
        /// <typeparam name="V">The vertex index type</typeparam>
        /// <typeparam name="W">The weight type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Edge<S,T>((S src, T dst) x)
            => new Edge<S,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public Edge(S src, T dst)
        {
            Source = src;
            Target = dst;
        }

        public override string ToString()
            => $"{Source} -> {Target}";
    }
}