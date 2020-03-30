//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Core
    {
        /// <summary>
        /// Returns the numeric value represented by a natural type
        /// </summary>
        /// <param name="n">The natural type representativev</param>
        /// <typeparam name="K">A natural type</typeparam>
        [MethodImpl(Inline)]
        public static ulong value<K>(K n = default)
            where K : unmanaged, ITypeNat
                => TypeNats.value(n);
    }
}