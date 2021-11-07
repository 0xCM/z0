//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Graphs
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Vertex16 : IEquatable<Vertex16>, IComparable<Vertex16>
    {
        public ushort Key {get;}

        [MethodImpl(Inline)]
        public Vertex16(ushort key)
        {
            Key = key;
        }

        public string Format()
            => Key.ToString();

        [MethodImpl(Inline)]
        public int CompareTo(Vertex16 src)
            => Key.CompareTo(src.Key);

        [MethodImpl(Inline)]
        public bool Equals(Vertex16 src)
            => Key.Equals(src.Key);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Key;

        public override bool Equals(object src)
            => src is Vertex16 v && Equals(v);

        [MethodImpl(Inline)]
        public static implicit operator Vertex16(ushort key)
            => new Vertex16(key);

        [MethodImpl(Inline)]
        public static bool operator ==(Vertex16 a, Vertex16 b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Vertex16 a, Vertex16 b)
            => !a.Equals(b);
    }
}