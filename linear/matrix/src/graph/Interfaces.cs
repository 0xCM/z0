//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Collections.Generic;
    using System.Linq;


    public interface IEdge
    {
        
    }

    public interface IEdge<V> : IEdge
        where V : unmanaged
    {
        V Source {get;}

        V Target {get;}
    }

    public interface IEdge<V,W> : IEdge<V>
        where V : unmanaged
        where W : unmanaged
    {
        W Weight {get;}
    }

    public interface IVertex
    {
        
    }    

    public interface IVertex<V> : IVertex
        where V : unmanaged
    {
        /// <summary>
        /// The index of the vertex that uniquely identifies
        /// it within a graph
        /// </summary>
        V Index {get;}        
    }    

    public interface IVertex<V,T> : IVertex<V>
        where V : unmanaged
        where T : unmanaged
    {
        T Data {get;} 
    }    


    public interface IGraph
    {

    }

    public interface IGraph<V> : IGraph
        where V : unmanaged
    {
        ReadOnlySpan<Vertex<V>> Vertices{get;}

        ReadOnlySpan<Edge<V>> Edges {get;}
    }

    public interface IGraph<V,T> : IGraph<V>
        where V : unmanaged
        where T : unmanaged
    {

    }
}