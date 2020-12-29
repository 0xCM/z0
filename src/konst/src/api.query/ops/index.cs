//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Part;
    using static z;

    partial struct ApiQuery
    {
        [Op]
        public static ApiMemberCodeIndex index(ApiMemberIndex members, ApiOpIndex<ApiCodeBlock> code)
        {
            var apicode = from pair in intersect(members, code).Enumerated
                          let l = pair.Item1
                          let r = pair.Item2
                          select new ApiMemberCode(r.left, r.right);
            return new ApiMemberCodeIndex(freeze(apicode.Select(c => (c.Id, c))));
        }

        [Op, Closures(UInt64k)]
        public static ApiOpIndex<T> index<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate)
        {
            var items = src.ToArray();
            var identities = items.Select(x => x.Item1).ToArray();
            var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                             where g.Count() > 1
                             select g.Key).ToHashSet();

            var HashTable = new Dictionary<OpIdentity,T>();

            if(duplicates.Count() != 0)
            {
                if(deduplicate)
                    HashTable = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    corefunc.@throw(DuplicateKeyException(duplicates));
            }
            else
                HashTable = src.ToDictionary();

            return new ApiOpIndex<T>(HashTable, duplicates.Select(d => OpIdentityParser.parse(d)).Array());
        }

        [Op]
        public static ApiMemberIndex index(ApiHostCatalog src)
        {
            var ix = index(src.Storage.Select(h => (h.Id, h)),true);
            return new ApiMemberIndex(ix.HashTable, ix.Duplicates);
        }

        static ApiOpIndex<T> freeze<T>(IEnumerable<(OpIdentity,T)> src)
        {
            try
            {
                var items = src.ToArray();
                var identities = items.Select(x => x.Item1).ToArray();
                var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                                where g.Count() > 1
                                select g.Key).ToHashSet();

                var dst = new Dictionary<OpIdentity,T>();
                if(duplicates.Count() != 0)
                    dst = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    dst = src.ToDictionary();
                return new ApiOpIndex<T>(dst, duplicates.Select(d => OpIdentityParser.parse(d)).Array());
            }
            catch(Exception e)
            {
                term.error(e);
                return ApiOpIndex<T>.Empty;
            }
        }

        [Op, Closures(UInt64k)]
        static ApiOpIndex<(L left, R right)> intersect<L,R>(IApiOpIndex<L> left, IApiOpIndex<R> right)
        {
             var keys = left.Keys.ToHashSet();
             keys.IntersectWith(right.Keys);
             var keylist = keys.ToArray();
             var count = keylist.Length;
             var entries = sys.alloc<(OpIdentity,(L,R))>(count);
             for(var i=0; i<count; i++)
             {
                var key = keylist[i];
                entries[i] = (key, (left[key], right[key]));
             }
             return index(entries,true);
         }
    }
}