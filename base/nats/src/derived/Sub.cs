//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;

    /// <summary>
    /// Encodes a natural number k := k1 - k2
    /// </summary>
    public readonly struct Sub<K1, K2> : INatSub<Sub<K1,K2>, K1,K2>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {
        static K1 k1 => default;

        static K2 k2 => default;

        public static string Description => $"{k1} - {k2} = {Value}";

        public static ulong Value
            => NatMath.sub(k1,k2);

        public static byte[] Digits 
            => digits(Value);

        public static NatSeq Seq
            => Nat.reflect(Digits);

        ulong ITypeNat.NatValue 
            => Value;

        public bool Equals(Pow<K1, K2> other)
            => Value == other.NatValue;

        public bool Equals(NatSeq other)
            => Value == other.NatValue;

        public override string ToString() 
            => Description;

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);
    }

}