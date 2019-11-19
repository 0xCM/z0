//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

 
    using static constant;


    public static class NatMath
    {
        
        /// <summary>
        /// For k1 % k2 = 0, computes k := k1 / k2
        /// </summary>
        /// <param name="k1"></param>
        /// <param name="k2"></param>
        /// <typeparam name="K1"></typeparam>
        /// <typeparam name="K2"></typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static NatVal multiples<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat<K1>, INatDivisible<K1,K2>
            where K2 : unmanaged, ITypeNat<K2>
                => NatVal.From(natval(k1) / natval(k2));
        
        [MethodImpl(Inline)]
        public static NatVal natval<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatVal.From(natval0<N>());

        [MethodImpl(Inline)]
        public static NatVal add<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() + natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal sub<T0,T1>(T0 a = default, T1 b = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() - natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal mul<T0,T1>(T0 a = default, T1 b = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() * natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal mul<T0,T1,T2>(T0 a = default, T1 b = default, T2 c = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
            where T2 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() * natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal div<T0,T1>(T0 a = default, T1 b = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() / natval0<T1>());

        /// <summary>
        /// Computes the quotient z of a product, z := a*b / c
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal divprod<T0,T1,T2>(T0 a = default, T1 b = default, T2 c = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
            where T2 : unmanaged, ITypeNat
                => NatVal.From(mul(a,b) / natval(c));


        [MethodImpl(Inline)]
        public static NatVal mod<T0,T1>(T0 a = default, T1 b = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() % natval0<T1>());

        /// <summary>
        /// Computes the modulus z of a product, z := a*b % c
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal modprod<T0,T1,T2>(T0 a = default, T1 b = default, T2 c = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
            where T2 : unmanaged, ITypeNat
                => NatVal.From(mul(a,b) % natval(c));


        [MethodImpl(Inline)]
        public static NatVal and<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() & natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal or<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() | natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal xor<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() ^ natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal not<T0>(T0 n0 = default)
            where T0 : unmanaged, ITypeNat
                => NatVal.From(~natval0<T0>());

        [MethodImpl(Inline)]
        public static NatVal sll<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() << (int)natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal srl<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => NatVal.From(natval0<T0>() >> (int)natval0<T1>());

        /// <summary>
        /// Applies a logical left-shift to a natural product: result := a*b << offset
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal sllprod<T0,T1,T2>(T0 a = default, T1 b = default, T2 offset = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
            where T2 : unmanaged, ITypeNat
                => NatVal.From(mul<T0,T1>() << (int)natval0<T2>());

        /// <summary>
        /// Applies a logical right-shift to a natural product: result := a*b >> offset
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal srlprod<T0,T1,T2>(T0 a = default, T1 b = default, T2 offset = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
            where T2 : unmanaged, ITypeNat
                => NatVal.From(mul<T0,T1>() >> (int)natval0<T2>());

        [MethodImpl(Inline)]
        public static bool eq<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => natval0<T0>() == natval0<T1>();

        [MethodImpl(Inline)]
        public static bool lt<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => natval0<T0>() < natval0<T1>();

        [MethodImpl(Inline)]
        public static bool lteq<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => natval0<T0>() <= natval0<T1>();

        [MethodImpl(Inline)]
        public static bool gt<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => natval0<T0>() > natval0<T1>();

        [MethodImpl(Inline)]
        public static bool gteq<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
                => natval0<T0>() >= natval0<T1>();
                
        [MethodImpl(Inline)]
        public static T rotr<T,T0,T1>()
            where T : unmanaged
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
        {
            if(typeof(T) == typeof(byte))
            {
                var result = (byte)rotrN<N8,T0,T1>();
                return Unsafe.As<byte,T>(ref result);
            }
            else if(typeof(T) == typeof(ushort))
            {
                var result = (ushort)rotrN<N16,T0,T1>();
                return Unsafe.As<ushort,T>(ref result);
            }
            else if(typeof(T) == typeof(uint))
            {
                var result = (uint)rotrN<N32,T0,T1>();
                return Unsafe.As<uint,T>(ref result);
            }
            else if(typeof(T) == typeof(ulong))
            {
                var result = (ulong)rotrN<N64,T0,T1>();
                return Unsafe.As<ulong,T>(ref result);
            }
            else
                return default(T);
        }

        [MethodImpl(Inline)]
        public static NatVal pow2<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatVal.From(1ul << (int)natval0<N>());

        [MethodImpl(Inline)]
        static ulong rotrN<B,T0,T1>()
            where B : unmanaged, ITypeNat
            where T0 : unmanaged, ITypeNat
            where T1 : unmanaged, ITypeNat
        {
            var x = srl<T0,T1>();
            var sr = sub<B,T1>();
            return srl<T0,T1>() |  ((ulong)natval0<T0>() << sub<B,T1>());
        }

        [MethodImpl(Inline)]
        public static NatVal natval<T0,T1>(T0 n0 = default, T1 n1 = default)
            where T0 : unmanaged, INatPrimitive<T0>
            where T1 : unmanaged, INatPrimitive<T1>
                => NatVal.From(10*natval0<T0>() + natval0<T1>());

        [MethodImpl(Inline)]
        public static NatVal natval<T0,T1,T2>(T0 n0 = default, T1 n1 = default, T2 n2 = default)
            where T0 : unmanaged, INatPrimitive<T0>
            where T1 : unmanaged, INatPrimitive<T1>
            where T2 : unmanaged, INatPrimitive<T2>
                => NatVal.From(100*natval0<T0>() + 10*natval0<T1>() + natval0<T2>());

        [MethodImpl(Inline)]
        public static NatVal natval<T0,T1,T2,T3>(T0 n0 = default, T1 n1 = default, T2 n2 = default, T3 n3 = default)
            where T0 : unmanaged, INatPrimitive<T0>
            where T1 : unmanaged, INatPrimitive<T1>
            where T2 : unmanaged, INatPrimitive<T2>
            where T3 : unmanaged, INatPrimitive<T3>        
                => NatVal.From(1000*natval0<T0>() + 100*natval0<T1>() + 10*natval0<T2>() + natval0<T3>());
        
        [MethodImpl(Inline)]
        public static NatVal natval<T0,T1,T2,T3,T4>(T0 n0 = default, T1 n1 = default, T2 n2 = default, T3 n3 = default, T4 n4 = default)
            where T0 : unmanaged, INatPrimitive<T0>
            where T1 : unmanaged, INatPrimitive<T1>
            where T2 : unmanaged, INatPrimitive<T2>
            where T3 : unmanaged, INatPrimitive<T3>
            where T4 : unmanaged, INatPrimitive<T4>
                => NatVal.From(10000*natval0<T0>() + 1000*natval0<T1>() + 100*natval0<T2>() + 10*natval0<T3>() + natval0<T4>());

    
        [MethodImpl(Inline)]
        static ulong natval0<N>()
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N0))
                return 0;
            else if(typeof(N) == typeof(N1))
                return 1;
            else if(typeof(N) == typeof(N2))
                return 2;
            else if (typeof(N) == typeof(N3))
                return 3;
            else if (typeof(N) == typeof(N4))
                return 4;
            else if (typeof(N) == typeof(N5))
                return 5;
            else if (typeof(N) == typeof(N6))
                return 6;
            else if (typeof(N) == typeof(N7))
                return 7;
            else if (typeof(N) == typeof(N8))
                return 8;
            else if (typeof(N) == typeof(N9))
                return 9;
            else 
                return natval10<N>();
        }

        [MethodImpl(Inline)]
        static ulong natval10<N>()
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N10))
                return 10;
            else if(typeof(N) == typeof(N11))
                return 11;
            else if(typeof(N) == typeof(N12))
                return 12;
            else if (typeof(N) == typeof(N13))
                return 13;
            else if (typeof(N) == typeof(N14))
                return 14;
            else if (typeof(N) == typeof(N15))
                return 15;
            else if (typeof(N) == typeof(N16))
                return 16;
            else if (typeof(N) == typeof(N17))
                return 17;
            else if (typeof(N) == typeof(N18))
                return 18;
            else if (typeof(N) == typeof(N19))
                return 19;
            else 
                return natval20<N>();
        }

        [MethodImpl(Inline)]
        static ulong natval20<N>()
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N20))
                return 20;
            else if(typeof(N) == typeof(N21))
                return 21;
            else if(typeof(N) == typeof(N22))
                return 22;
            else if (typeof(N) == typeof(N23))
                return 23;
            else if (typeof(N) == typeof(N24))
                return 24;
            else if (typeof(N) == typeof(N25))
                return 25;
            else if (typeof(N) == typeof(N26))
                return 26;
            else if (typeof(N) == typeof(N27))
                return 27;
            else if (typeof(N) == typeof(N28))
                return 28;
            else if (typeof(N) == typeof(N29))
                return 29;
            else 
                return natval30<N>();
        }

        [MethodImpl(Inline)]
        static ulong natval30<N>()
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N30))
                return 30;
            else if(typeof(N) == typeof(N31))
                return 31;
            else 
                return natpow2_32<N>();
        }

        [MethodImpl(Inline)]
        static ulong natpow2_32<N>()
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N32))
                return 32;
            else if(typeof(N) == typeof(N64))
                return 64;
            else if(typeof(N) == typeof(N128))
                return 128;
            else if(typeof(N) == typeof(N256))
                return 256;
            else if(typeof(N) == typeof(N512))
                return 512;
            else if(typeof(N) == typeof(N1024))
                return 1024;
            else if(typeof(N) == typeof(N2048))
                return 2048;
            else if(typeof(N) == typeof(N4096))
                return 4096;
            else 
                return natpow2_8192<N>();
                
        }

        [MethodImpl(Inline)]
        static ulong natpow2_8192<N>()
            where N : unmanaged, ITypeNat
        {
            if(typeof(N) == typeof(N8192))
                return 8192;
            else if(typeof(N) == typeof(N16384))
                return 16384;
            else if(typeof(N) == typeof(N32768))
                return 32768;
            else 
                return new N().NatValue;
        }

    }

}