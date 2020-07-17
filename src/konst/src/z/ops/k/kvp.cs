//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                
        /// <summary>
        /// Creates a kvp
        /// </summary>
        /// <param name="key">The key</param>
        /// <param name="value">The value</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline), Op]
        public static KeyedValue<K,V> kvp<K,V>(K key, V value)
            => new KeyedValue<K,V>(key,value);
            
    }
}