//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Graphs;

    /// <summary>
    /// Defines a vertex to which data may be attached
    /// </summary>
    /// <typeparam name="V">The vertex index type</typeparam>
    /// <typeparam name="T">The payload type</typeparam>
    public readonly struct Vertex<V,T>
        where T : unmanaged
        where V : unmanaged
    {
        /// <summary>
        /// The index of the vertex that uniquely identifies it within a graph
        /// </summary>
        public readonly V Index;

        /// <summary>
        /// The vertex payload
        /// </summary>
        public readonly T Data;

        [MethodImpl(Inline)]
        public static Edge<V> operator +(in Vertex<V,T> source, in Vertex<V,T> target)
            => source.Connect(target);

        /// <summary>
        /// Sheds the associated data to form a payload-free vertex
        /// </summary>
        /// <param name="src">The source vertex</param>
        [MethodImpl(Inline)]
        public static implicit operator Vertex<V>(in Vertex<V,T> src)
            => new Vertex<V>(src.Index);

        [MethodImpl(Inline)]
        public Vertex(V Index, T Data)
        {
            this.Index = Index;
            this.Data = Data;
        }

        public override string ToString() 
            => $"({Index},{Data})";
    }
}