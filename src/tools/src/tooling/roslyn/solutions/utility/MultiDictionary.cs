//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/source-indexer
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public class MultiDictionary<K,V> : Dictionary<K,HashSet<V>>
    {
        readonly IEqualityComparer<V> ValueComparer;

        public MultiDictionary()
        {
        }

        public MultiDictionary(IEqualityComparer<K> keyComparer, IEqualityComparer<V> valueComparer)
            : base(keyComparer)
        {
            ValueComparer = valueComparer;
        }

        public void Add(K key, V value)
        {
            if (EqualityComparer<K>.Default.Equals(default(K), key))
                sys.@throw(new ArgumentNullException(nameof(key)));

            if (!TryGetValue(key, out HashSet<V> bucket))
                Add(key, new HashSet<V>(ValueComparer));

            bucket.Add(value);
        }
    }
}