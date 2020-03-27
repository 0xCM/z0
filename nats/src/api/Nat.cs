//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static Components;

    /// <summary>
    /// Constructs natural number prepresentatives and calculates related values
    /// </summary>
    public static class Nat
    {        
        public static int require<N>(int value, N n = default)
            where N : unmanaged, ITypeNat
                => nati<N>() == value ? value : throw new Exception();

        /// <summary>
        /// Consructs the canonical sequence representatives for the natural numbers within an inclusive range
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public static IEnumerable<NatSeq> reflect(uint min, uint max)
        {
            for(var i = min; i<= max; i++)
                yield return reflect(i);
        }

        /// <summary>
        /// Constructs the natural type corresponding to an integral value
        /// </summary>
        /// <param name="digits">The source digits</param>
        [MethodImpl(Inline)]       
        public static NatSeq reflect(uint value)        
            => reflect(digits(value));

        /// <summary>
        /// Constructs an array of types that defines a sequence of natural primitives
        /// </summary>
        /// <param name="digits">The digit values where each value is in the range 0..9</param>
        [MethodImpl(Inline)]       
        public static Type[] seqtypes(byte[] digits)
        {
            var types = new Type[digits.Length];
            ref var tHead = ref types[0];
            ref var dHead = ref digits[0];
            for(var i=0; i< digits.Length; i++)
                Unsafe.Add(ref tHead, i) = primtype(Unsafe.Add(ref dHead, i));
            return types;            
        }

        /// <summary>
        /// Constructs a type natural from a sequence of digits
        /// </summary>
        /// <param name="digits">The source digits</param>
        public static NatSeq reflect(byte[] digits)
        {
            var dtypes = seqtypes(digits);
            var nattype = seqdef((uint)dtypes.Length).MakeGenericType(dtypes);
            return (NatSeq)Activator.CreateInstance(nattype);
        }
        
        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(2), 
                    primtype(d1), primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d2, byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(3), 
                    primtype(d2), primtype(d1), primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d3, byte d2, byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(4), 
                    primtype(d3), primtype(d2), primtype(d1), primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d4, byte d3, byte d2, byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(5), 
                    primtype(d4), primtype(d3), primtype(d2), primtype(d1), 
                    primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d5, byte d4, byte d3, byte d2, byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(6), 
                    primtype(d5), primtype(d4), primtype(d3), primtype(d2), 
                    primtype(d1), primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d6, byte d5, byte d4, byte d3, byte d2, byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(7), 
                    primtype(d6), primtype(d5), primtype(d4), primtype(d3), 
                    primtype(d2), primtype(d1), primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        public static NatSeq reflect(byte d7, byte d6, byte d5, byte d4, byte d3, byte d2, byte d1, byte d0)
            => (NatSeq) Activator.CreateInstance(close(seqdef(8), 
                    primtype(d7), primtype(d6), primtype(d5), primtype(d4), 
                    primtype(d3), primtype(d2), primtype(d1), primtype(d0)
                    ));                    

        [MethodImpl(Inline)]   
        static Type close(Type t, params Type[] args)
            => t.MakeGenericType(args);
        
        /// <summary>
        /// Constructs a natural representative for a specified parametric type
        /// </summary>
        /// <typeparam name="K">The representative type to construct</typeparam>
        [MethodImpl(Inline)]   
        public static K nat<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;

        [MethodImpl(Inline)]   
        public static Next<K> next<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;

        [MethodImpl(Inline)]   
        public static Prior<K> prior<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Defines a digit relative to a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        [MethodImpl(Inline)]   
        public static Digit<N,T> digit<N,T>(T src, N @base = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Digit<N,T>(src);

        /// <summary>
        /// Constructs (k1,k2) where k1:K2 & k2:K2 
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        [MethodImpl(Inline)]   
        public static (ulong k1, ulong k2) pair<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K2 : unmanaged, ITypeNat
            where K1 : unmanaged, ITypeNat
                => (natu<K1>(), natu<K2>());            

        [MethodImpl(Inline)]   
        public static (int k1, int k2) pairi<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K2 : unmanaged, ITypeNat
            where K1 : unmanaged, ITypeNat
                => (nati<K1>(), nati<K2>());            

        /// <summary>
        /// Constructs (k1,k2,k3) where k1:K2 & k2:K2 & k3:K3
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <typeparam name="K3">The thrid type</typeparam>
        [MethodImpl(Inline)]   
        public static (ulong k1, ulong k2, ulong k3) triple<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K2 : unmanaged, ITypeNat
            where K1 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => (natu<K1>(),natu<K2>(), natu<K3>());            

        /// <summary>
        /// Constructs a natural representative that encodes the sum of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSum<K1,K2> add<K1,K2>()
            where K1 : unmanaged, ITypeNat        
            where K2 : unmanaged, ITypeNat
                => NatSum<K1,K2>.Rep;

        /// <summary>
        /// Encodes a natural number k := k1 + k2
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSum<K1,K2> sum<K1,K2>(K1 k1 = default, K2 k2 =default)
            where K1 : unmanaged, ITypeNat        
            where K2 : unmanaged, ITypeNat
                => NatSum<K1,K2>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes the product of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static Product<K1,K2> product<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat        
            where K2 : unmanaged, ITypeNat
                => Product<K1,K2>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes a natural base raised to a
        /// natural power
        /// </summary>
        /// <typeparam name="B">The base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        [MethodImpl(Inline)]   
        public static Pow<B,E> pow<B,E>()
            where B : unmanaged, ITypeNat        
            where E : unmanaged, ITypeNat
                => Pow<B,E>.Rep;

        /// <summary>
        /// Constructs a natural representative that encodes a natural prime base raised to a
        /// natural power
        /// </summary>
        /// <typeparam name="P">The prime base type</typeparam>
        /// <typeparam name="E">The exponent type</typeparam>
        [MethodImpl(Inline)]   
        public static PrimePow<P,E> primepow<P,E>()
            where P : unmanaged, ITypeNat, INatPrime<P>
            where E : unmanaged, ITypeNat
                => PrimePow<P,E>.Rep;

        /// <summary>
        /// Constructs the natural dimension (k1,k2) where k1:K1 & k2:K2 
        /// </summary>
        /// <typeparam name="K1">The first dimensional factor</typeparam>
        /// <typeparam name="K2">The second dimensional factor</typeparam>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2> dim<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat        
            where K2 : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Constructs the natural dimension (k1,k2,k3) where k1:K1 & k2:K2 & k3:K3
        /// </summary>
        [MethodImpl(Inline)]   
        public static Dim<K1,K2,K3> dim<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, ITypeNat        
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Constructs the canonical 2-element natural sequence for the 2-digit natural number k such that
        /// {k1:K1, k2:K2} => k = k1*10 + k2
        /// </summary>
        /// <typeparam name="K1">The first nat type, corresponding the first digit of the associated value</typeparam>
        /// <typeparam name="K2">The second nat type, corresponding the second digit of the associated value</typeparam>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2> seq<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
                => NatSeq<K1,K2>.Rep;

        /// <summary>
        /// Constructs the canonical 3-element natural sequence for the 3-digit natural number k such that
        /// {k1:K1, k2:K2, k3:K3} => k = k1*10^2 + k2*10^1 + k3
        /// </summary>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3> seq<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
                => default;
        
        /// <summary>
        /// Constructs the canonical 4-element natural sequence for the 4-digit natural number k such that
        /// {k1:K1, ..., k4:K4} => k = k1*10^3 + k2*10^2 + k3*10 + K4
        /// </summary>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3,K4> seq<K1,K2,K3,K4>(K1 k1 = default, K2 k2 = default, K3 k3 = default, K4 k4 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
            where K4 : unmanaged, INatPrimitive<K4>
                => default;

        /// <summary>
        /// Constructs the canonical 5-element natural sequence for the 5-digit natural number k such that
        /// {k1:K1 ... k5:K5} => k = k1*10^4 + k2*10^3 + k3*10^2 + K4*10 + k5
        /// </summary>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3,K4,K5> seq<K1,K2,K3,K4,K5>(K1 k1 = default, K2 k2 = default, K3 k3 = default, K4 k4 = default, K5 k5 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
            where K4 : unmanaged, INatPrimitive<K4>
            where K5 : unmanaged, INatPrimitive<K5>
                => default;

        /// <summary>
        /// Constructs the canonical 6-element natural sequence for the 6-digit natural number k such that
        /// {k1:K1, ..., k6:K6} => k = k1*10^5 + k2*10^4 + k3*10^3 + K4*10^2 + k5*10 + k6
        /// </summary>
        [MethodImpl(Inline)]   
        public static NatSeq<K1,K2,K3,K4,K5,K6> seq<K1,K2,K3,K4,K5,K6>(K1 k1 = default, K2 k2 = default, K3 k3 = default, K4 k4 = default, K5 k5 = default, K6 k6 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
            where K4 : unmanaged, INatPrimitive<K4>
            where K5 : unmanaged, INatPrimitive<K5>
            where K6 : unmanaged, INatPrimitive<K6>
                => default;      

        /// <summary>
        /// Recuces the representation to canonical form
        /// </summary>
        /// <typeparam name="K1">The source natural</typeparam>
        /// <typeparam name="K2">The target natural</typeparam>
        [MethodImpl(Inline)]   
        public static K2 reduce<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
        {                        
            var tval = Nat.nat<K2>();
            var sval = Nat.nat<K1>();
            NatClaim.eq(tval, sval);
            return tval;
        }

        /// <summary>
        /// For a natural number n <= 9, returns the type of the corresponding natural primitive. If n > 9, returns the zero type
        /// </summary>
        /// <param name="n">The number to evaluate</param>
        [MethodImpl(Inline)]   
        static Type primtype(byte n)
        {
            if(n == 1)
                return typeof(N1);
            else if(n == 2)
                return typeof(N2);
            else if(n == 3)
                return typeof(N3);
            else if(n == 4)
                return typeof(N4);
            else if(n == 5)
                return typeof(N5);
            else if(n == 6)
                return typeof(N6);
            else if(n == 7)
                return typeof(N7);
            else if(n == 8)
                return typeof(N8);
            else if(n == 9)
                return typeof(N9);
            else
                return typeof(N0);
        }

        /// <summary>
        /// Computes the generic type definition for a natural sequence
        /// </summary>
        /// <param name="length">The sequence length</param>
        [MethodImpl(Inline)]   
        static Type seqdef(uint length)
        {
            if(length == 2)
                return typedef(typeof(NatSeq<,>));
            else if(length == 3)
                return typedef(typedef(typeof(NatSeq<,,>)));
            else if(length == 4)
                return typedef(typeof(NatSeq<,,,>)); 
            else if(length == 5)
                return typedef(typeof(NatSeq<,,,,>)); 
            else if(length == 6)
                return typedef(typeof(NatSeq<,,,,,>)); 
            else if(length == 7)
                return typedef(typeof(NatSeq<,,,,,,>)); 
            else if(length == 8)
                return typedef(typeof(NatSeq<,,,,,,,>)); 
            else if(length == 9)
                return typedef(typeof(NatSeq<,,,,,,,,>)); 
            else
                return typeof(NatSeq1<>);
        }

        [MethodImpl(Inline)]   
        static Type typedef(Type t)
            => t.GetGenericTypeDefinition();

        /// <summary>
        /// Computes the value of type nat
        /// </summary>
        /// <param name="n">The power of 2 exponent, between 0 and 63</param>
        /// <typeparam name="K">The exponent type</typeparam>
        [MethodImpl(Inline)]
        public static ulong value<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N0))
                return 0;
            else if(typeof(K) == typeof(N1))
                return 1;
            else if(typeof(K) == typeof(N2))
                return 2;
            else if(typeof(K) == typeof(N3))
                return 3;
            else if(typeof(K) == typeof(N4))
                return 4;
            else if(typeof(K) == typeof(N5))
                return 5;
            else if(typeof(K) == typeof(N6))
                return 6;
            else if(typeof(K) == typeof(N7))
                return 7;
            else
                return value_8(n);
        }

        [MethodImpl(Inline)]
        static ulong value_8<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N8))
                return 8;
            else if(typeof(K) == typeof(N9))
                return 9;
            else if(typeof(K) == typeof(N10))
                return 10;
            else if(typeof(K) == typeof(N11))
                return 11;
            else if(typeof(K) == typeof(N12))
                return 12;
            else if(typeof(K) == typeof(N13))
                return 13;
            else if(typeof(K) == typeof(N14))
                return 14;
            else if(typeof(K) == typeof(N15))
                return 15;
            else
                return value_16(n);
        }

        [MethodImpl(Inline)]
        static ulong value_16<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N16))
                return 16;
            else if(typeof(K) == typeof(N17))
                return 17;
            else if(typeof(K) == typeof(N18))
                return 18;
            else if(typeof(K) == typeof(N19))
                return 19;
            else if(typeof(K) == typeof(N20))
                return 20;
            else if(typeof(K) == typeof(N21))
                return 21;
            else if(typeof(K) == typeof(N22))
                return 22;
            else if(typeof(K) == typeof(N23))
                return 23;
            else
                return value_24(n);
        }

        [MethodImpl(Inline)]
        static ulong value_24<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N24))
                return 24;
            else if(typeof(K) == typeof(N25))
                return 25;
            else if(typeof(K) == typeof(N26))
                return 26;
            else if(typeof(K) == typeof(N27))
                return 27;
            else if(typeof(K) == typeof(N28))
                return 28;
            else if(typeof(K) == typeof(N29))
                return 29;
            else if(typeof(K) == typeof(N30))
                return 30;
            else if(typeof(K) == typeof(N31))
                return 31;
            else
                return value_32(n);
        }

        [MethodImpl(Inline)]
        static ulong value_32<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N32))
                return 32;
            else if(typeof(K) == typeof(N33))
                return 33;
            else if(typeof(K) == typeof(N34))
                return 34;
            else if(typeof(K) == typeof(N35))
                return 35;
            else if(typeof(K) == typeof(N36))
                return 36;
            else if(typeof(K) == typeof(N37))
                return 37;
            else if(typeof(K) == typeof(N38))
                return 38;
            else if(typeof(K) == typeof(N39))
                return 39;
            else
                return value_40(n);
        }

        [MethodImpl(Inline)]
        static ulong value_40<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N40))
                return 40;
            else if(typeof(K) == typeof(N41))
                return 41;
            else if(typeof(K) == typeof(N42))
                return 42;
            else if(typeof(K) == typeof(N43))
                return 43;
            else if(typeof(K) == typeof(N44))
                return 44;
            else if(typeof(K) == typeof(N45))
                return 45;
            else if(typeof(K) == typeof(N46))
                return 46;
            else if(typeof(K) == typeof(N47))
                return 47;
            else
                return value_48(n);
        }
 
        [MethodImpl(Inline)]
        static ulong value_48<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N48))
                return 48;
            else if(typeof(K) == typeof(N49))
                return 49;
            else if(typeof(K) == typeof(N50))
                return 50;
            else if(typeof(K) == typeof(N51))
                return 51;
            else if(typeof(K) == typeof(N52))
                return 52;
            else if(typeof(K) == typeof(N53))
                return 53;
            else if(typeof(K) == typeof(N54))
                return 54;
            else if(typeof(K) == typeof(N55))
                return 55;
            else
                return value_56(n);
        }

        [MethodImpl(Inline)]
        static ulong value_56<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N56))
                return 56;
            else if(typeof(K) == typeof(N57))
                return 57;
            else if(typeof(K) == typeof(N58))
                return 58;
            else if(typeof(K) == typeof(N59))
                return 59;
            else if(typeof(K) == typeof(N60))
                return 60;
            else if(typeof(K) == typeof(N61))
                return 61;
            else if(typeof(K) == typeof(N62))
                return 62;
            else if(typeof(K) == typeof(N63))
                return 63;
            else
                return value_64(n);
        }

        [MethodImpl(Inline)]
        static ulong value_64<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N64))
                return 64;
            else if(typeof(K) == typeof(N128))
                return 128;
            else if(typeof(K) == typeof(N256))
                return 256;
            else if(typeof(K) == typeof(N512))
                return 512;
            else if(typeof(K) == typeof(N1024))
                return 1024;
            else if(typeof(K) == typeof(N2048))
                return 2048;
            else if(typeof(K) == typeof(N4096))
                return 4096;
            else if(typeof(K) == typeof(N8192))
                return 8192;
            else
                return default(K).NatValue;
        }
    }
}