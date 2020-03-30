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
        /// Constructs a natural representative that encodes the product of two naturals
        /// </summary>
        /// <typeparam name="K1">The first operand type</typeparam>
        /// <typeparam name="K2">The second operand type</typeparam>
        [MethodImpl(Inline)]   
        public static Product<K1,K2> product<K1,K2>(K1 k1 = default, K2 k2 = default)
            where K1 : unmanaged, ITypeNat        
            where K2 : unmanaged, ITypeNat
                => Product<K1,K2>.Rep;
    }
}