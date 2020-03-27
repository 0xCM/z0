//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static Components;

    /// <summary>
    /// Encodes a natural number k := b^e
    /// </summary>
    public readonly struct Pow<B,E> : INatPow<Pow<B, E>, B, E>
        where B : unmanaged, ITypeNat
        where E : unmanaged, ITypeNat
    {
        public static Pow<B,E> Rep => default;

        public static  ITypeNat[] Operands => new ITypeNat[] {new B(), new E()};            

        /// <summary>
        /// Raises a baise to a power
        /// </summary>
        /// <param name="@base">The base value</param>
        /// <param name="exp">The exponent value</param>
        [MethodImpl(Inline)]
        static ulong pow(ulong @base, ulong exp)
            => repeat(@base, exp).Aggregate((x,y) => x * y); 

        public static ulong Value
            => pow(Nat.nat<B>().NatValue, Nat.nat<E>().NatValue);
            
        public static byte[] Digits => digits(Value);

        public static NatSeq Seq => Nat.reflect(Digits);


        public NatSeq Sequence
            => Seq;

        public ulong NatValue 
            => Value;

        public NatSeq natseq()
            => Seq;

        public E Exponent 
            => new E();

         public string format()
            => Value.ToString();

        public override string ToString() 
            => format();

        public override int GetHashCode()
            => Value.GetHashCode();

        public override bool Equals(object rhs)
            => Value.Equals(rhs);

        public bool Equals(Pow<B, E> other)
            => Value == other.NatValue;

        public bool Equals(NatSeq other)
            => Value == other.NatValue;

    }
}