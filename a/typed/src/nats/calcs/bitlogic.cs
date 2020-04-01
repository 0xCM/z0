//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    using static Seed;
    using static TypeNats;

    partial class NatCalc
    {
        /// <summary>
        /// Computes k := k1 & k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong and<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => value(k1) & value(k2);

        /// <summary>
        /// Computes k := k1 | k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong or<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => value(k2) | value(k2);

        /// <summary>
        /// Computes k := k1 ^ k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong xor<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => value(k1) ^ value(k2);

        /// <summary>
        /// Computes k := ~k1
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong not<K1>(K1 k1 = default)
            where K1 : unmanaged, ITypeNat
                => ~ value(k1);
    }
}