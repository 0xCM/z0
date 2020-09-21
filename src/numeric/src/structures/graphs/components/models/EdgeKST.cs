//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Edge<K,S,T>
        where K : unmanaged
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The classifier
        /// </summary>
        public readonly K Kind;

        /// <summary>
        /// The source
        /// </summary>
        public readonly S Source;

        /// <summary>
        /// The target
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
        public static implicit operator Edge<K,S,T>((K kind, S src, T dst) x)
            => new Edge<K,S,T>(x.kind, x.src, x.dst);

        [MethodImpl(Inline)]
        public Edge(K kind, S src, T dst)
        {
            Kind = kind;
            Source = src;
            Target = dst;
        }

        public override string ToString()
            => $"{Source} -> {Target}";
    }
}