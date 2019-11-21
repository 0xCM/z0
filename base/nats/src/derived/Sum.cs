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

        public NatSeq Sequence
            => Rep.Sequence;

        public ulong NatValue
            => Rep.NatValue;
    }
    
    /// <summary>
    /// Encodes a natural number k := k1 + k2
    /// </summary>
    public readonly struct NatSum<K1, K2> : INatSum<K1,K2>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {
        static K1 k1 => default;

        static K2 k2 => default;

        public static NatSum<K1,K2> Rep => default;
        
        public static ulong Value => NatMath.add(k1,k2);

        static string description => $"{k1} + {k2} = {Value}";

        public static byte[] Digits => digits(Value);

        public static NatSeq Seq => Nat.reflect(Digits);

        [MethodImpl(Inline)]
        public static implicit operator int(NatSum<K1,K2> src)
            => (int)src.NatValue;

        NatSeq ITypeNat.Sequence
            => Seq;

        public ulong NatValue 
            => NatMath.add(k1,k2);

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