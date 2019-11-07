//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static constant;

    /// <summary>
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1 - k2
    /// </summary>
    public readonly struct Sub<K1, K2> : INatSub<Sub<K1,K2>, K1,K2>
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
    {
        static K1 k1 => default;

        static K2 k2 => default;

        public static Sub<K1,K2> Rep => default;

        public static ulong Value
            => k1.value - k2.value;

        static string description => $"{k1} - {k2} = {Value}";

        public static byte[] Digits 
            => digits(Value);

        public static NatSeq Seq
            => Nat.reflect(Digits);

        NatSeq ITypeNat.seq
            => Seq;

        ulong ITypeNat.value 
            => Value;

        public NatSeq natseq()
            => Seq;

        public bool Equals(Pow<K1, K2> other)
            => Value == other.value;

        public bool Equals(NatSeq other)
            => Value == other.value;

        public string format()
            => description;

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);
    }

}