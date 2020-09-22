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

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static Konst;
    using static z;

    partial struct ApiIdentity
    {
        [Op]
        public static ApiCodeIndex index(ApiMemberIndex members, OpIndex<X86UriHex> code)
            => ApiCodeIndex.create(members,code);

        /// <summary>
        /// Creates an operation index from an api member span, readonly that is
        /// </summary>
        /// <param name="src">The members to index</param>
        /// <typeparam name="M">The member type</typeparam>
        public static OpIndex<M> index<M>(ReadOnlySpan<M> src)
            where M : struct, IApiMember
                => index(src.MapArray(h => (h.Id, h)));

        /// <summary>
        /// Creates an operation index from a uri bitstream
        /// </summary>
        /// <param name="src">The source bits</param>
        [Op]
        public static OpIndex<X86UriHex> index(IEnumerable<X86UriHex> src)
            => index(src.Select(x => (x.OpUri.OpId, x)));

        static Exception DuplicateKeyException(IEnumerable<object> keys, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new Exception(text.concat($"Duplicate keys were detected {keys.FormatList()}",  caller,file, line));

        public static OpIndex<T> index<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
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
                    throw DuplicateKeyException(duplicates);
            }
            else
                HashTable = src.ToDictionary();

            var duplicated = duplicates.Select(d => ApiIdentityParser.parse(d)).ToArray();
            return new OpIndex<T>(HashTable, duplicated);
        }
    }
}