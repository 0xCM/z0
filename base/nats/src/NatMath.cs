//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    using static constant;

    public static class NatMath
    {        
        [MethodImpl(Inline)]
        public static NatVal natval<K>(K n = default)
            where K : unmanaged, ITypeNat
                => NatVal.From(default(K).NatValue);

        /// <summary>
        /// For k1 % k2 = 0, computes k := k1 / k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal multiples<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat<K1>, INatDivisible<K1,K2>
            where K2 : unmanaged, ITypeNat<K2>
                => NatVal.From(natval(k1) / natval(k2));

        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal add<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) + natval(k2));

        /// <summary>
        /// Computes k := k1 - k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal sub<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) + natval(k2));

        /// <summary>
        /// Computes k := k1*k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal mul<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) * natval(k2));

        /// <summary>
        /// Computes k := k1*k2*k3
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal mul<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) * natval(k2) * natval(k3));

        /// <summary>
        /// Computes k := k1*k1
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal square<K1>(K1 k1 = default)
            where K1 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) * natval(k1));

        /// <summary>
        /// Computes k := k1 / k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal div<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval<K1>() / natval<K2>());

        /// <summary>
        /// Computes k := (k1*k2) / k3
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal divprod<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(mul(k1,k2) / natval(k3));

        /// <summary>
        /// Computes k := k1 % k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal mod<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) % natval(k2));

        /// <summary>
        /// Computes k := k % 2 == 0
        /// </summary>
        [MethodImpl(Inline)]
        public static bool even<K1>(K1 k1 = default)
            where K1 : unmanaged, ITypeNat
                => natval(k1) % 2 == 0;

        /// <summary>
        /// Computes k := k % 2 != 0
        /// </summary>
        [MethodImpl(Inline)]
        public static bool odd<K1>(K1 k1 = default)
            where K1 : unmanaged, ITypeNat
                => natval(k1) % 2 != 0;

        /// <summary>
        /// Computes k := (k1*k2) % k3
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal modprod<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(mul(k1,k2) % natval(k3));

        /// <summary>
        /// Computes k := k1 & k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal and<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) & natval(k2));

        /// <summary>
        /// Computes k := k1 | k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal or<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k2) | natval(k2));

        /// <summary>
        /// Computes k := k1 ^ k2
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal xor<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) ^ natval(k2));

        /// <summary>
        /// Computes k := ~k1
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal not<K1>(K1 k1 = default)
            where K1 : unmanaged, ITypeNat
                => NatVal.From(~ natval(k1));

        [MethodImpl(Inline)]
        public static NatVal sll<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) << natval(k2));

        [MethodImpl(Inline)]
        public static NatVal srl<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) >> natval(k2));

        /// <summary>
        /// Applies a logical left-shift to a natural product: result := a*b << offset
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal sllprod<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 shift = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(mul(k1,k2) << natval(shift));

        /// <summary>
        /// Computes := a*b >> offset
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal srlprod<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 shift = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(mul(k1,k2) >> natval(shift));

        [MethodImpl(Inline)]
        public static bool eq<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => natval(k1) == natval(k2);

        [MethodImpl(Inline)]
        public static bool lt<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => natval(k1) < natval(k2);

        [MethodImpl(Inline)]
        public static bool lteq<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => natval(k1) <= natval(k2);

        [MethodImpl(Inline)]
        public static bool gt<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => natval(k1) > natval(k2);

        [MethodImpl(Inline)]
        public static bool gteq<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => natval(k1) >= natval(k2);

        [MethodImpl(Inline)]
        public static bool between<K,K1,K2>(K k = default, K1 k1 = default, K2 k2 = default)
            where K : unmanaged, ITypeNat
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => gteq(k,k1) && lteq(k,k2);

        [MethodImpl(Inline)]
        public static T rotr<T,K1,K2>(K1 k1 = default, K2 k2 = default, T zero = default)
            where T : unmanaged
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
        {
            if(typeof(T) == typeof(byte))
            {
                var result = (byte)rotrN<N8,K1,K2>();
                return Unsafe.As<byte,T>(ref result);
            }
            else if(typeof(T) == typeof(ushort))
            {
                var result = (ushort)rotrN<N16,K1,K2>();
                return Unsafe.As<ushort,T>(ref result);
            }
            else if(typeof(T) == typeof(uint))
            {
                var result = (uint)rotrN<N32,K1,K2>();
                return Unsafe.As<uint,T>(ref result);
            }
            else if(typeof(T) == typeof(ulong))
            {
                var result = (ulong)rotrN<N64,K1,K2>();
                return Unsafe.As<ulong,T>(ref result);
            }
            else
                return default(T);
        }

        [MethodImpl(Inline)]
        public static ulong pow2m1<N>(N n = default)
            where N : unmanaged, ITypeNat
                => pow2(n) - 1ul;

        /// <summary>
        /// Computes k := 2^n
        /// </summary>
        /// <param name="n"></param>
        /// <typeparam name="K"></typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ulong pow2<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N0))
                return 1ul;
            else if(typeof(K) == typeof(N1))
                return 1ul << 1;
            else if(typeof(K) == typeof(N2))
                return 1ul << 2;
            else if(typeof(K) == typeof(N3))
                return 1ul << 3;
            else if(typeof(K) == typeof(N4))
                return 1ul << 4;
            else if(typeof(K) == typeof(N5))
                return 1ul << 5;
            else if(typeof(K) == typeof(N6))
                return 1ul << 6;
            else if(typeof(K) == typeof(N7))
                return 1ul << 7;
            else
                return pow2_8(n);
        }

        [MethodImpl(Inline)]
        static ulong pow2_8<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N8))
                return 1ul << 8;
            else if(typeof(K) == typeof(N9))
                return 1ul << 9;
            else if(typeof(K) == typeof(N10))
                return 1ul << 10;
            else if(typeof(K) == typeof(N11))
                return 1ul << 11;
            else if(typeof(K) == typeof(N12))
                return 1ul << 12;
            else if(typeof(K) == typeof(N13))
                return 1ul << 13;
            else if(typeof(K) == typeof(N14))
                return 1ul << 14;
            else if(typeof(K) == typeof(N15))
                return 1ul << 15;
            else
                return pow2_16(n);
        }

        [MethodImpl(Inline)]
        static ulong pow2_16<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N16))
                return 1ul << 16;
            else if(typeof(K) == typeof(N17))
                return 1ul << 17;
            else if(typeof(K) == typeof(N18))
                return 1ul << 18;
            else if(typeof(K) == typeof(N19))
                return 1ul << 19;
            else if(typeof(K) == typeof(N20))
                return 1ul << 20;
            else if(typeof(K) == typeof(N21))
                return 1ul << 21;
            else if(typeof(K) == typeof(N22))
                return 1ul << 22;
            else if(typeof(K) == typeof(N23))
                return 1ul << 23;
            else
                return pow2_24(n);
        }

        [MethodImpl(Inline)]
        static ulong pow2_24<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N24))
                return 1ul << 24;
            else if(typeof(K) == typeof(N25))
                return 1ul << 25;
            else if(typeof(K) == typeof(N26))
                return 1ul << 26;
            else if(typeof(K) == typeof(N27))
                return 1ul << 27;
            else if(typeof(K) == typeof(N28))
                return 1ul << 28;
            else if(typeof(K) == typeof(N29))
                return 1ul << 29;
            else if(typeof(K) == typeof(N30))
                return 1ul << 30;
            else if(typeof(K) == typeof(N31))
                return 1ul << 31;
            else
                return pow2_32(n);
        }

        [MethodImpl(Inline)]
        static ulong pow2_32<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N32))
                return 1ul << 32;
            else if(typeof(K) == typeof(N33))
                return 1ul << 33;
            else if(typeof(K) == typeof(N34))
                return 1ul << 34;
            else if(typeof(K) == typeof(N35))
                return 1ul << 35;
            else if(typeof(K) == typeof(N36))
                return 1ul << 36;
            else if(typeof(K) == typeof(N37))
                return 1ul << 37;
            else if(typeof(K) == typeof(N38))
                return 1ul << 38;
            else if(typeof(K) == typeof(N39))
                return 1ul << 39;
            else
                return pow2_40(n);
        }

        [MethodImpl(Inline)]
        static ulong pow2_40<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N40))
                return 1ul << 40;
            else if(typeof(K) == typeof(N41))
                return 1ul << 41;
            else if(typeof(K) == typeof(N42))
                return 1ul << 42;
            else if(typeof(K) == typeof(N43))
                return 1ul << 43;
            else if(typeof(K) == typeof(N44))
                return 1ul << 44;
            else if(typeof(K) == typeof(N45))
                return 1ul << 45;
            else if(typeof(K) == typeof(N46))
                return 1ul << 46;
            else if(typeof(K) == typeof(N47))
                return 1ul << 47;
            else
                return pow2_48(n);
        }
 
        [MethodImpl(Inline)]
        static ulong pow2_48<K>(K n = default)
            where K : unmanaged, ITypeNat
        {
            if(typeof(K) == typeof(N48))
                return 1ul << 48;
            else if(typeof(K) == typeof(N49))
                return 1ul << 49;
            else if(typeof(K) == typeof(N50))
                return 1ul << 50;
            else if(typeof(K) == typeof(N51))
                return 1ul << 51;
            else if(typeof(K) == typeof(N52))
                return 1ul << 52;
            else if(typeof(K) == typeof(N53))
                return 1ul << 53;
            else if(typeof(K) == typeof(N54))
                return 1ul << 54;
            else if(typeof(K) == typeof(N55))
                return 1ul << 55;
            else
                return 1ul << natval<K>(); 
        }
 
        [MethodImpl(Inline)]
        static ulong rotrN<K3,K1,K2>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K3 : unmanaged, ITypeNat
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => (ulong)srl(k1,k2) |  ((ulong)natval(k1) << sub(k3,k2));

        [MethodImpl(Inline)]
        public static NatVal natseq<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
                => NatVal.From(NatSeq<K1,K2>.Value);

        [MethodImpl(Inline)]
        public static NatVal natseq<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
                => NatVal.From(NatSeq<K1,K2,K3>.Value);

        [MethodImpl(Inline)]
        public static NatVal natseq<K1,K2,K3,K4>(K1 k1 = default, K2 k2 = default, K3 k3 = default, K4 k4 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
            where K4 : unmanaged, INatPrimitive<K4>        
                => NatVal.From(NatSeq<K1,K2,K3,K4>.Value);
        
        [MethodImpl(Inline)]
        public static NatVal natseq<K1,K2,K3,K4,K5>(K1 k1 = default, K2 k2 = default, K3 k3 = default, K4 k4 = default, K5 k5 = default)
            where K1 : unmanaged, INatPrimitive<K1>
            where K2 : unmanaged, INatPrimitive<K2>
            where K3 : unmanaged, INatPrimitive<K3>
            where K4 : unmanaged, INatPrimitive<K4>
            where K5 : unmanaged, INatPrimitive<K5>
                => NatVal.From(NatSeq<K1,K2,K3,K4,K5>.Value);
    }

}