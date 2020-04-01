//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    /// <summary>
    /// Defines an unweighted edge, parameterized by the vertex index type
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    public readonly struct Edge<V>
        where V : unmanaged
    {
        /// <summary>
        /// The index of the source vertex
        /// </summary>
        public readonly V Source;

        /// <summary>
        /// The index of the target vertex
        /// </summary>
        public readonly V Target;

        [MethodImpl(Inline)]
        public static implicit operator (V src, V dst)(Edge<V> edge)
            => (edge.Source,edge.Target);

        [MethodImpl(Inline)]
        public static implicit operator Edge<V>((V src, V dst) x)
            => (x.src,x.dst);
        
        [MethodImpl(Inline)]
        public Edge(V src, V dst)
        {
            this.Source = src;
            this.Target = dst;
        }
        
        public string Format() 
            => $"{Source} -> {Target}";

        public override string ToString() 
            => Format();
    }
}