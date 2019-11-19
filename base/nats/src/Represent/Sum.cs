//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static constant;

    public readonly struct NatSum<K> : INatSum<K>
        where K : unmanaged, ITypeNat
    {
        public static K Rep => default;

        internal NatSum(ITypeNat lhs, ITypeNat rhs)
        {
            this.Lhs = lhs;
            this.Rhs = rhs;
        }
        
        public ITypeNat Lhs {get;}

        public ITypeNat Rhs {get;}

        NatSeq ITypeNat.Sequence
            => Rep.Sequence;

        ulong ITypeNat.NatValue
            => Rep.NatValue;


    }
    /// <summary>
    /// Encodes a natural number k such that k1:K1 & k2:K2 => k = k1 + k2
    /// </summary>
    public readonly struct NatSum<K1, K2> : INatSum<K1,K2>
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
    {
        static K1 k1 => default;

        static K2 k2 => default;

        public static NatSum<K1,K2> Rep => default;

        
        public static ulong Value => k1.NatValue + k2.NatValue;

        static string description => $"{k1} + {k2} = {Value}";

        public static byte[] Digits  => digits(Value);

        public static NatSeq Seq => Nat.reflect(Digits);

        [MethodImpl(Inline)]
        public static implicit operator int(NatSum<K1,K2> src)
            => (int)src.value;

        NatSeq ITypeNat.Sequence
            => Seq;

        ulong ITypeNat.NatValue 
            => Value;

        public ulong value 
            => Value;

        public NatSeq natseq()
            => Seq;

        public bool Equals(Pow<K1, K2> other)
            => Value == other.NatValue;

        public bool Equals(NatSeq other)
            => Value == other.NatValue;

        public override string ToString() 
            => description;

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);
 
        [MethodImpl(Inline)]
        public NatSum<K> Reduce<K>(K target = default)
            where K : unmanaged, ITypeNat
        {
            if(Value == target.NatValue)
                return new NatSum<K>(k1,k2);
            else 
                throw new Exception($"{k1} + {k2} != {target}");
        } 
    }
}