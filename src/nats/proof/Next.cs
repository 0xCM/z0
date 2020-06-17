//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    
    public static class NextNat
    {
        [MethodImpl(Inline)]   
        public static Next<K> get<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;
    }

    /// <summary>
    /// When closed over a natural K, encodes a natural number k:K such that k1:K1 & k2:K2 => k = k1 + 1
    /// </summary>
    public readonly struct Next<K> : ITypeNat
        where K : unmanaged, ITypeNat
    {        
        static K k => default;

        public static Next<K> Rep => default;

        public static ulong Value => k.NatValue + 1u;

        static string description => $"++{k.NatValue} = {Value}";

        public static byte[] Digits  => TypeNats.digits(Value);

        public static INatSeq Seq => TypeNats.seq(Digits);

        public ITypeNat rep 
            => Rep;

        public INatSeq Sequence
            => Seq;

        public ulong NatValue 
            => Value;

        public INatSeq natseq()
            => Seq;

        public bool Equals(Next<K> rhs)
            => Value == rhs.NatValue;

        public bool Equals(INatSeq rhs)
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