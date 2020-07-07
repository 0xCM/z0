//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    partial struct Encoded
    {
        public static EncodedIndex freeze(in EncodedIndexBuilder builder)
        {
            var memtable = HashTable.Create(builder.CodeAddress);
            var memuri = HashTable.Create(builder.UriAddress);  
            var hc = memtable.Values.Select(x => (x.OpUri.Host, x))
                                         .GroupBy(g => g.Host)
                                         .Select(x => (x.Key, x.Select(y => y.x).ToArray()))
                                         .ToDictionary();
            var parts = hc.Keys.Select(x => x.Owner).Distinct().ToArray();

            return new EncodedIndex(parts, memtable, memuri, hc); 
        }
    }
}