//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static RootShare;

    public static class IdentityExtensions
    {
        /// <summary>
        /// Returns the duplicate identities found in the source stream, if any; otherwisse,
        /// returns an empty array
        /// </summary>
        /// <param name="src">The identities to search for duplicates</param>
        public static OpIdentity[] Duplicates(this IEnumerable<OpIdentity> src)
        {
            var index = new Dictionary<OpIdentity,int>();            
            var distinct = src.ToHashSet();
            if(distinct.Count != src.Count())
            {
                foreach(var id in src)
                {
                    if(index.TryGetValue(id, out var count ))
                        index[id] = ++count;
                    else
                        index[id] = 1;
                }
            }

            return (from kvp in index where kvp.Value > 1 select kvp.Key).ToArray();
        }
    }
}