//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Characterizes an atom of the type natural grammar
    /// </summary>
    /// <typeparam name="N">The reifying type</typeparam>
    public interface INatPrimitive<N> : ITypeNat<N>
        where N : unmanaged, INatPrimitive<N>
    {
        
    }

    /// <summary>
    /// The singleton type representative for 0
    /// </summary>
    public readonly struct N0 : ITypeNat<N0>, INatSeq<N0>, INatPrimitive<N0>, INatEven<N0>, INatNext<N0,N1>
    {
        public const ulong Value = 0;

        public static N0 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N0 src) => 0;
        
        public ulong NatValue  => Value;

        public NatSeq Sequence => this;

        public override string ToString() 
            => Value.ToString();
    }

    /// <summary>
    /// The singleton type representative for 1
    /// </summary>
    public readonly struct N1 : ITypeNat<N1>, INatPrimitive<N1>, INatSeq<N1>, INatNonZero<N1>, 
        INatPow<N1,N1,N0>, INatOdd<N1>, INatPrior<N1,N0>, INatNext<N1,N2>, INatPow2<N0>
    {
        public const ulong Value = 1;

        public static N1 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N1 src) => 1;

        [MethodImpl(Inline)]
        public static implicit operator W1(N1 src) => default(W1);

        [MethodImpl(Inline)]
        public static implicit operator N1(W1 src) => default(N1);

        public NatSeq Sequence => this;

        public ulong NatValue => Value;

        public override string ToString() 
            => Value.ToString();
    }

    /// <summary>
    /// The type that represents 2
    /// </summary>
    public readonly struct N2 : 
        ITypeNat<N2>, 
        INatSeq<N2>, 
        INatPrimitive<N2>,
        INatPrime<N2>, 
        INatPow<N2,N2,N1>, 
        INatEven<N2>, 
        INatNonZero<N2>, 
        INatPrior<N2,N1>, 
        INatNext<N2,N3>,
        INatPow2<N1>        
    {
        public const ulong Value = 2;

        public static N2 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N2 src) => 2;

        public ulong NatValue => Value;
        
        public NatSeq Sequence => this;
        
        public override string ToString() 
            => Value.ToString();
    }

    /// <summary>
    /// The singleton type representative for 3
    /// </summary>
    public readonly struct N3 : 
        ITypeNat<N3>, 
        INatSeq<N3>,
        INatPrime<N3>, 
        INatPrimitive<N3>, 
        INatOdd<N3>,
        INatNonZero<N3>, 
        INatPrior<N3,N2>, 
        INatNext<N3,N4>
    {
        public const ulong Value = 3;

        public static N3 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N3 src) => 3;

        public ulong NatValue => Value;

        public NatSeq Sequence => this;

        public override string ToString() 
            => Value.ToString();
    }

    /// <summary>
    /// The singleton type representative for 4
    /// </summary>
    public readonly struct N4 : 
        ITypeNat<N4>, 
        INatSeq<N4>, 
        INatPow<N4,N2,N2>, 
        INatPrimitive<N4>, 
        INatEven<N4>,
        INatNonZero<N4>, 
        INatPrior<N4,N3>, 
        INatNext<N4,N5>,
        INatPow2<N2>        
    {
        public const ulong Value = 4;

        public static N4 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N4 src) => 4;

        public ulong NatValue  => Value;

        public NatSeq Sequence
            => this;

        public string format()
            => NatValue.ToString();

        public override string ToString() 
            => format();

    }

    /// <summary>
    /// The singleton type representative for 5
    /// </summary>
    public readonly struct N5 : 
        ITypeNat<N5>, 
        INatSeq<N5>,
        INatPrime<N5>, 
        INatPrimitive<N5>, 
        INatOdd<N5>,
        INatNonZero<N5>, 
        INatPrior<N5,N4>, 
        INatNext<N5,N6>
    {
        public const ulong Value = 5;
        public static N5 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N5 src) => 5;

        public ulong NatValue => Value;

        public NatSeq Sequence => this;

        public override string ToString() 
            => Value.ToString();
    }

    /// <summary>
    /// The singleton type representative for 6
    /// </summary>
    public readonly struct N6 : 
        ITypeNat<N6>, 
        INatSeq<N6>, 
        INatPrimitive<N6>, 
        INatNonZero<N6>, 
        INatEven<N6>, 
        INatPrior<N6,N5>, 
        INatNext<N6,N7>,
        INatDivisible<N6,N3>
    {
        public const ulong Value = 6;

        public static N6 Rep => default;


        [MethodImpl(Inline)]
        public static implicit operator int(N6 src) => 6;

        public ulong NatValue => 6;

        public NatSeq Sequence => this;


        public override string ToString() 
            => Value.ToString();
 
     }

    /// <summary>
    /// The singleton type representative for 7
    /// </summary>
    public readonly struct N7 : 
        ITypeNat<N7>, 
        INatSeq<N7>,
        INatPrime<N7>, 
        INatPrimitive<N7>, 
        INatOdd<N7>, 
        INatNonZero<N7>, 
        INatPrior<N7,N6>, 
        INatNext<N7,N8>
    {
        public const ulong Value = 7;

        public static N7 Rep => default;

        [MethodImpl(Inline)]
        public static implicit operator int(N7 src) => 7;

        public ulong NatValue => 7;

        public NatSeq Sequence => this;


        public override string ToString() 
            => Value.ToString();
 
    }

    /// <summary>
    /// The singleton type representative for 8
    /// </summary>
    public readonly struct N8 : 
        ITypeNat<N8>, 
        INatSeq<N8>,
        INatPow<N8,N2,N3>, 
        INatPrimitive<N8>, 
        INatEven<N8>,
        INatNonZero<N8>, 
        INatPrior<N8,N7>, 
        INatNext<N8,N9>,
        INatPow2<N3>,
        INatDivisible<N8,N4>        

    { 
        public const ulong Value = 8;

        public static N8 Rep => default;
     
        [MethodImpl(Inline)]
        public static implicit operator int(N8 src) => 8;

        [MethodImpl(Inline)]
        public static implicit operator W8(N8 src) => default(W8);

        [MethodImpl(Inline)]
        public static implicit operator N8(W8 src) => default(N8);

        public ulong NatValue => 8;

        public NatSeq Sequence
            => this;

        public string format()
            => NatValue.ToString();

        public override string ToString() 
            => format();
         
    }

    /// <summary>
    /// The singleton type representative for 9
    /// </summary>
    public readonly struct N9 : 
        ITypeNat<N9>, 
        INatSeq<N9>,
        INatPrimitive<N9>, 
        INatOdd<N9>,
        INatNonZero<N9>, 
        INatPrior<N9,N8>,
        INatDivisible<N9,N3>
    {
        public const ulong Value = 9;

        public static N9 Rep => default;
         
        [MethodImpl(Inline)]
        public static implicit operator int(N9 src) => 9;
  
        public ulong NatValue => 9;

        public NatSeq Sequence=> this;

        public override string ToString() 
            => Value.ToString();             
    }
}