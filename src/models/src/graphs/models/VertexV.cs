//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Models
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IVertex
    {

    }

    public interface IVertex<V> : IVertex
        where V : IEquatable<V>
    {
        V Identity {get;}
    }

    partial struct Graphs
    {
        public readonly struct Vertex<V> : IVertex<V>
            where V : IEquatable<V>
        {
            public V Identity {get;}

            [MethodImpl(Inline)]
            public Vertex(V identity)
            {
                Identity = identity;
            }

            [MethodImpl(Inline)]
            public bool Equals(Vertex<V> src)
                => Identity.Equals(src.Identity);

            public override int GetHashCode()
                => (int)hash(Identity);

            public override bool Equals(object obj)
                => obj is Vertex<V> v && Equals(v);

            [MethodImpl(Inline)]
            public static implicit operator Vertex<V>(V src)
                => new Vertex<V>(src);
        }
    }
}