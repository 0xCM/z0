//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct Sequential : ITextual, IComparable<Sequential>, IEquatable<Sequential>
    {
        public uint Value;

        [MethodImpl(Inline)]
        public Sequential(uint src)
            => Value = src;

        [MethodImpl(Inline)]
        public int CompareTo(Sequential other)
            => Value.CompareTo(other.Value);

        [MethodImpl(Inline)]
        public bool Equals(Sequential other)
            => Value.Equals(other.Value);

        [MethodImpl(Inline)]
        public string Format()
            => Value.ToString();

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static Sequential operator ++(Sequential src)
            => new Sequential(++src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Sequential(uint src)
            => new Sequential(src);

        [MethodImpl(Inline)]
        public static implicit operator Sequential(int src)
            => new Sequential((uint)src);

        [MethodImpl(Inline)]
        public static implicit operator uint(Sequential src)
            => src.Value;
    }
}