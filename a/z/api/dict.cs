//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class Root
    {
        /// <summary>
        /// Creates a new dictionary with an optionally-specified capacity
        /// </summary>
        /// <param name="capacity">The capacity</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]   
        public static Dictionary<K,V> dict<K,V>(int capacity = 0)
            => new Dictionary<K,V>(capacity);

        /// <summary>
        /// Creates a new dictionary populated with an initial set of entries
        /// </summary>
        /// <param name="entries">The initial entries</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]   
        public static Dictionary<K,V> dict<K,V>(params (K key, V value)[] entries)
            => entries.ToDictionary();

    }
}