//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class OpIndex
    {        
        public static OpIndex<T> From<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
            => Create(src,deduplicate);

        public static OpIndex<T> ToOpIndex<T>(this IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
            => Create(src,deduplicate);

        public static OpIndex<(L left, R right)> Intersect<L,R>(this IOpIndex<L> left, IOpIndex<R> right)
        {
             var keys = left.Keys.ToHashSet();
             keys.IntersectWith(right.Keys);
             var keylist = keys.ToArray();
             var count = keylist.Length;
             var entries = Arrays.alloc<(OpIdentity,(L,R))>(count);
             for(var i=0; i<count; i++)
             {
                var key = keylist[i];
                entries[i] = (key, (left[key], right[key]));
             }
             return entries.ToOpIndex();
         }   

        static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(text.concat($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));

        public static OpIndex<T> Create<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate)
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
            
            var duplicated = duplicates.Select(d => Identify.Op(d)).ToArray();
            return new OpIndex<T>(HashTable, duplicated);
        }
    }
}