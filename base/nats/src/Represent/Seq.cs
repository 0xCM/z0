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

    using static constant;
    using static nfunc;

    /// <summary>
    /// Characterizes a type-level sequence of typenats
    /// </summary>
    public interface NatSeq : ITypeNat
    {

    }

    /// <summary>
    /// Characterizes a natural sequence with an unspecified number of terms
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    public interface INatSeq<S> : ITypeNat<S>, NatSeq
        where S : INatSeq<S>, new()
    {

    }


    /// <summary>
    /// Reifies a one-term natural sequence
    /// </summary>
    /// <typeparam name="K1">The type of the first term</typeparam>
    public readonly struct NatSeq1<K1> : INatSeq<NatSeq1<K1>>
        where K1 : unmanaged, INatPrimitive<K1>
    {
        public static NatSeq1<K1> Rep => default;
        
        public static ulong Value =>
             Nat.nat<K1>().value;
                
        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a two-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2> : INatSeq<NatSeq<K1,K2>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
    {
        public static NatSeq<K1,K2> Rep => default;

        public static ulong Value =>
              Nat.nat<K1>().value * 10
            + Nat.nat<K2>().value;

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 
    
        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a three-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3> : INatSeq<NatSeq<K1,K2,K3>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
    {
        public static NatSeq<K1,K2,K3> Rep => default;
        
        public static ulong Value =>
             Nat.nat<K1>().value * 100
            + Nat.nat<K2>().value * 10
            + Nat.nat<K3>().value;

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a four-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4> : INatSeq<NatSeq<K1,K2,K3,K4>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
    {
        public static NatSeq<K1,K2,K3,K4> Rep => default;

        public static ulong Value =>
              Nat.nat<K1>().value * 1000
            + Nat.nat<K2>().value * 100
            + Nat.nat<K3>().value * 10
            + Nat.nat<K4>().value;

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a five-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4,K5> : INatSeq<NatSeq<K1,K2,K3,K4,K5>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
    {
        public static NatSeq<K1,K2,K3,K4,K5> Rep => default;

        public static ulong Value =>
              Nat.nat<K1>().value * 10000
            + Nat.nat<K2>().value * 1000
            + Nat.nat<K3>().value * 100
            + Nat.nat<K4>().value * 10
            + Nat.nat<K5>().value;

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a six-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6> : INatSeq<NatSeq<K1,K2,K3,K4,K5,K6>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
        where K6 : unmanaged, INatPrimitive<K6>
    {
        public static NatSeq<K1,K2,K3,K4,K5,K6> Rep => default;

        public static ulong Value => 
              Nat.nat<K1>().value * 100000
            + Nat.nat<K2>().value * 10000
            + Nat.nat<K3>().value * 1000
            + Nat.nat<K4>().value * 100
            + Nat.nat<K5>().value * 10
            + Nat.nat<K6>().value;
    
        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies a seven-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6,K7> : INatSeq<NatSeq<K1,K2,K3,K4,K5,K6,K7>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
        where K6 : unmanaged, INatPrimitive<K6>
        where K7 : unmanaged, INatPrimitive<K7>
    {
        public static NatSeq<K1,K2,K3,K4,K5,K6,K7> Rep => default;

        public static ulong Value =>
              Nat.nat<K1>().value * 1000000
            + Nat.nat<K2>().value * 100000
            + Nat.nat<K3>().value * 10000
            + Nat.nat<K4>().value * 1000
            + Nat.nat<K5>().value * 100
            + Nat.nat<K6>().value * 10
            + Nat.nat<K7>().value;

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }

    /// <summary>
    /// Reifies an eight-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6,K7,K8> : INatSeq<NatSeq<K1,K2,K3,K4,K5,K6,K7,K8>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
        where K6 : unmanaged, INatPrimitive<K6>
        where K7 : unmanaged, INatPrimitive<K7>
        where K8 : unmanaged, INatPrimitive<K8>
    {
        public static NatSeq<K1,K2,K3,K4,K5,K6,K7,K8> Rep => default;

        public static ulong Value =>
              Nat.nat<K1>().value * 10000000
            + Nat.nat<K2>().value * 1000000
            + Nat.nat<K3>().value * 100000
            + Nat.nat<K4>().value * 10000
            + Nat.nat<K5>().value * 1000
            + Nat.nat<K6>().value * 100
            + Nat.nat<K7>().value * 10
            + Nat.nat<K8>().value;

        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    } 

    /// <summary>
    /// Reifies an nine-term natural sequence
    /// </summary>
    public readonly struct NatSeq<K1,K2,K3,K4,K5,K6,K7,K8,K9> : INatSeq<NatSeq<K1,K2,K3,K4,K5,K6,K7,K8,K9>>
        where K1 : unmanaged, INatPrimitive<K1>
        where K2 : unmanaged, INatPrimitive<K2>
        where K3 : unmanaged, INatPrimitive<K3>
        where K4 : unmanaged, INatPrimitive<K4>
        where K5 : unmanaged, INatPrimitive<K5>
        where K6 : unmanaged, INatPrimitive<K6>
        where K7 : unmanaged, INatPrimitive<K7>
        where K8 : unmanaged, INatPrimitive<K8>
        where K9 : unmanaged, INatPrimitive<K9>
    {
        public static NatSeq<K1,K2,K3,K4,K5,K6,K7,K8,K9> Rep => default;

        public static ulong Value =>
              Nat.nat<K1>().value * 100000000
            + Nat.nat<K2>().value * 10000000
            + Nat.nat<K3>().value * 1000000
            + Nat.nat<K4>().value * 100000
            + Nat.nat<K5>().value * 10000
            + Nat.nat<K6>().value * 1000
            + Nat.nat<K7>().value * 100
            + Nat.nat<K8>().value * 10
            + Nat.nat<K9>().value; 


        public ulong value 
            => Value;

        public ITypeNat rep
            => Rep; 

        public NatSeq seq
            => Rep; 

        public string format()
            => Value.ToString();

        public override string ToString() 
            => format();
    }     
}