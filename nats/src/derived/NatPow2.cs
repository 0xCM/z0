//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    
    using static nfunc;
    using static Root;

    /// <summary>
    /// Reifies a natural k such that e:E => k = 2^e
    /// </summary>
    public readonly struct NatPow2<E> : INatPow2<E>
        where E : unmanaged, ITypeNat<E>
    {
        public static NatPow2<E> Rep => default;

        /// <summary>
        /// Raises a baise to a power
        /// </summary>
        /// <param name="@base">The base value</param>
        /// <param name="exp">The exponent value</param>
        static ulong pow(ulong @base, ulong exp)
            => repeat(@base, exp).Aggregate((x,y) => x * y); 

        public static readonly ulong Value
            = pow(Nat.nat<E>().NatValue, Nat.nat<E>().NatValue);
            
        public static readonly byte[] Digits 
            = digits(Value);

        public static readonly NatSeq Seq
            = Nat.reflect(Digits);

        public ITypeNat rep 
            => Rep;

        public NatSeq Sequence
            => Seq;

        public ulong NatValue 
            => Value;

        public NatSeq natseq()
            => Seq;

        public override string ToString() 
            => Value.ToString();

        public override int GetHashCode()
            => Value.GetHashCode();

        public bool Equals(NatPow2<E> rhs)
            => Value == rhs.NatValue;

        public bool Equals(NatSeq other)
            => Value == other.NatValue;

    }
}