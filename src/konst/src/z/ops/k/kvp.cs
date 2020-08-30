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
        /// Creates a unmanaged K-discriminated key over a T-identifier
        /// </summary>
        /// <param name="kind"></param>
        /// <param name="id"></param>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static Key<K,T> key<K,T>(K kind, T id)
            where K : unmanaged
            where T : unmanaged
                =>  new Key<K,T>(kind,id);

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