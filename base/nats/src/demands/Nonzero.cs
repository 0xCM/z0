//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static constant;

    /// <summary>
    /// Captures evidence that k != 0
    /// </summary>
    /// <typeparam name="K">A nonzero natural type</typeparam>
    public readonly struct Nonzero<K> : INatNonZero<K>
        where K: unmanaged, ITypeNat
    {
        static K k => default;
        
        public static string Description => $"{k} != 0";

        [MethodImpl(Inline)]
        public Nonzero(K n)
        {
            demand(n.NatValue != 0);
        }
            
        public override string ToString()
            => Description;
    }

}