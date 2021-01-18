//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static TypeNats;
    using static Part;

    partial class NatClaims
    {
        /// <summary>
        /// Attempts to prove that k:K => k != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        [MethodImpl(Inline)]
        public static NonzeroNat<K> nonzero<K>()
            where K: unmanaged, ITypeNat
                => new NonzeroNat<K>(natrep<K>());

        /// <summary>
        /// Attempts to prove that k:K => k != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        [MethodImpl(Inline)]
        public static NonzeroNat<K> nonzero<K>(K k)
            where K: unmanaged, ITypeNat
                => new NonzeroNat<K>(k);
    }
}