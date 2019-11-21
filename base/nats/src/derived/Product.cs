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
    /// Encodes a natural number k := k1*k2
    /// </summary>
    public readonly struct Product<K1, K2> : INatProduct<Product<K1,K2>, K1,K2>
        where K1 : unmanaged, ITypeNat
        where K2 : unmanaged, ITypeNat
    {
        static K1 k1 => default;

        static K2 k2 => default;

        public static Product<K1,K2> Rep => default;        
        
        public static ulong Value => k1.NatValue * k2.NatValue;

        static string description => $"{k1} * {k2} = {Value}";

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

        public bool Equals(Pow<K1, K2> other)
            => Value == other.NatValue;

        public bool Equals(NatSeq other)
            => Value == other.NatValue;

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