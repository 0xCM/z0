//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;
    using static UriDelimiters;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial class Identities
    {
        static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(text.concat($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));

        /// <summary>
        /// Returns the duplicate identities found in the source stream, if any; otherwise, returns an empty array
        /// </summary>
        /// <param name="src">The identities to search for duplicates</param>
        public static OpIdentity[] duplicates(IEnumerable<OpIdentity> src)
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
        
        public static OpIndex<T> index<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
        {
            var items = src.ToArray();
            var identities = items.Select(x => x.Item1).ToArray();
            var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                             where g.Count() > 1
                             select g.Key).ToHashSet();
            
            var HashTable = new Dictionary<OpIdentity, T>();            

            
            if(duplicates.Count() != 0)
            {
                if(deduplicate)
                    HashTable = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    throw DuplicateKeyException(duplicates);
            }
            else
                HashTable = src.ToDictionary();
            
            var duplicated = duplicates.Select(d => Identities.Op(d)).ToArray();
            return new OpIndex<T>(HashTable, duplicated);
        }


    }
}