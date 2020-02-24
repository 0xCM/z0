//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static Root;

    /// <summary>
    /// Captures evidence that n1 == n2
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="N2">The second nat type</typeparam>
     public readonly struct NatEq<K1,K2> : INatEq<K1,K2>
        where K1: unmanaged, ITypeNat
        where K2: unmanaged, ITypeNat
    {
        static K1 k1 => default;
        static K2 k2 => default;
        
        public static string Description => $"{k1} == {k2}";
        
        [MethodImpl(Inline)]
        public NatEq(K1 k1, K2 k2)
        {
            demand(NatMath.eq(k1,k2));
        }
        
        public override string ToString()
            => Description;
    }


}