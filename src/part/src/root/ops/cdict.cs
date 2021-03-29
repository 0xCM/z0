//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;

    using static Part;

    partial struct root
    {
        /// <summary>
        /// Initializes an empty concurrent dictionary
        /// </summary>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The vale type</typeparam>
        public static ConcurrentDictionary<K,V> cdict<K,V>()
            => new();
    }
}