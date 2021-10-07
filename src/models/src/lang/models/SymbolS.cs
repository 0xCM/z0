//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Symbol<K> : IComparable<Symbol<K>>, IEquatable<Symbol<K>>, ITerm<K>
        where K : unmanaged
    {
        public readonly uint Key;

        public readonly K Value;

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
    }
}