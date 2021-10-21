//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Vertex<V> : IVertex<V>, IEquatable<Vertex<V>>
    {
        public Label Name {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public Vertex(Label name, V value)
        {
            Name = name;
            Value = value;
        }

        [MethodImpl(Inline)]
        public bool Equals(Vertex<V> src)
            => Name.Equals(src.Name);

        public override int GetHashCode()
            => (int)graphs.hash(Value);

        public override bool Equals(object obj)
            => obj is Vertex<V> v && Equals(v);

        public string Format()
            => string.Format("{0}({1})", Name, Value);

        public override string ToString()
            => Format();
    }
}