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
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1 + 1
    /// </summary>
    public readonly struct Next<K> : ITypeNat
        where K : unmanaged, ITypeNat
    {        
        static K k => default;

        public static Next<K> Rep => default;

        public static ulong Value => k.NatValue + 1u;

        static string description => $"++{k.NatValue} = {Value}";

        public static byte[] Digits  => digits(Value);

        public static NatSeq Seq => Nat.reflect(Digits);

        public ITypeNat rep 
            => Rep;

        public NatSeq Sequence
            => Seq;

        public ulong NatValue 
            => Value;

        public NatSeq natseq()
            => Seq;

        public bool Equals(Next<K> rhs)
            => Value == rhs.NatValue;

        public bool Equals(NatSeq rhs)
            => Value == rhs.NatValue;

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
