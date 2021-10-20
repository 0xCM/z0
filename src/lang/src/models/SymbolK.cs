//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// A terminal atomic
    /// </summary>
    public readonly struct Symbol<K> : ISymbol<Symbol<K>,K>
        where K : unmanaged
    {
        public uint Key {get;}

        public K Value {get;}

        [MethodImpl(Inline)]
        public Symbol(uint key, K value)
        {
            Key = key;
            Value = value;
        }

        [MethodImpl(Inline)]

        public bool Equals(Symbol<K> src)
            => Key == src.Key && bw64(Value).Equals(bw64(src.Value));

        [MethodImpl(Inline)]
        public int CompareTo(Symbol<K> src)
            => bw64(Value).CompareTo(bw64(src.Value));

        public string Format()
            => Value.ToString();

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Key;

        public override bool Equals(object src)
            => src is Symbol<K> s && Equals(s);

        [MethodImpl(Inline)]
        public static bool operator ==(Symbol<K> a, Symbol<K> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(Symbol<K> a, Symbol<K> b)
            => !a.Equals(b);

        public static Symbol<K> Empty => default;
    }
}