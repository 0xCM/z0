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

        [MethodImpl(Inline)]
        public static NatVal add<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) + natval(k2));

        [MethodImpl(Inline)]
        public static NatVal sub<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) + natval(k2));

        [MethodImpl(Inline)]
        public static NatVal mul<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) * natval(k2));

        [MethodImpl(Inline)]
        public static NatVal mul<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) * natval(k2) * natval(k3));

        [MethodImpl(Inline)]
        public static NatVal div<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval<K1>() / natval<K2>());

        /// <summary>
        /// Computes the quotient z of a product, z := a*b / c
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
        /// Computes a := k % 2 == 0
        /// </summary>
        [MethodImpl(Inline)]
        public static bool even<K>(K k = default)
            where K : unmanaged, ITypeNat
                => natval(k) % 2 == 0;

        /// <summary>
        /// Computes a := k % 2 != 0
        /// </summary>
        [MethodImpl(Inline)]
        public static bool odd<K>(K k = default)
            where K : unmanaged, ITypeNat
                => natval(k) % 2 != 0;

        /// <summary>
        /// Computes z := a*b % c
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal modprod<K1,K2,K3>(K1 k1 = default, K2 k2 = default, K3 k3 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
            where K3 : unmanaged, ITypeNat
                => NatVal.From(mul(k1,k2) % natval(k3));

        [MethodImpl(Inline)]
        public static NatVal and<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) & natval(k2));

        [MethodImpl(Inline)]
        public static NatVal or<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k2) | natval(k2));

        [MethodImpl(Inline)]
        public static NatVal xor<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => NatVal.From(natval(k1) ^ natval(k2));

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

        /// <summary>
        /// Computes z := 2^n
        /// </summary>
        [MethodImpl(Inline)]
        public static NatVal pow2<N>(N n = default)
            where N : unmanaged, ITypeNat
                => NatVal.From(1ul << natval(n));

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