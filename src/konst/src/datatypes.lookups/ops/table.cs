//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Lookups
    {
        /// <summary>
        /// Creates a lookup table
        /// </summary>
        /// <param name="src">The table entries</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static LookupTable<K,V> table<K,V>(LookupEntry<K,V>[] src)
            where K : unmanaged
                => new LookupTable<K,V>(src);
    }
}