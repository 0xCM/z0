//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;    

    partial class NatClaim
    {    
        /// <summary>
        /// Attempts to prove that k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static NatSum<K1,K2> add<K1,K2>(uint expected)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
        {
            eq<NatSum<K1, K2>>((ulong)expected);
            return Nat.add<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static NatSum<K1,K2> add<K1,K2>(int expected)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
        {
            eq<NatSum<K1,K2>>(expected);
            return Nat.add<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static NatSum<K1,K2> sum<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
        {
            eq<NatSum<K1, K2>>((ulong)expected);
            return Nat.add<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static NatSum<K1,K2> add<K1,K2>(K1 k1, K2 k2, ulong expected)
            where K1 : unmanaged, ITypeNat
            where K2 : unmanaged, ITypeNat
        {
            eq<NatSum<K1,K2>>(expected);
            return Nat.add<K1,K2>();
        } 

    }
}