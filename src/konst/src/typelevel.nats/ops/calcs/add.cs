//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static TypeNats;


    partial class TypeNats
    {
        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong add<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => value(k1) + value(k2);

        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong min<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => zfunc.min(value(k1), value(k2));

        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong max<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => zfunc.max(value(k1), value(k2));

    }

    partial class NatCalc
    {
        [MethodImpl(Inline)]
        internal static ulong max(ulong a, ulong b)
            => a > b ? a : b;

        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong add<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => value(k1) + value(k2);

        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong min<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => zfunc.min(value(k1), value(k2));

        /// <summary>
        /// Computes k := k1 + k2
        /// </summary>
        [MethodImpl(Inline)]
        public static ulong max<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
                => zfunc.max(value(k1), value(k2));

    }
}