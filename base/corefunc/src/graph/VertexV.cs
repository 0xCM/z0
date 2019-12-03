//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    /// <summary>
    /// Defines a vertex within a graph
    /// </summary>
    public readonly struct Vertex<V>
        where V : unmanaged
    {        
        /// <summary>
        /// The index of the vertex that uniquely identifies it within a graph
        /// </summary>
        public readonly V Index;

        [MethodImpl(Inline)]
        public static Edge<V> operator +(in Vertex<V> source, in Vertex<V> target)
            => source.Connect(target);

        [MethodImpl(Inline)]
        public Vertex(V Index)
        {
            this.Index = Index;
        }

        public override string ToString() 
            => $"({Index})";
    }

}