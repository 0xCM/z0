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

    using static Konst;

    public readonly struct ApiMemberIndex : IOpIndex<ApiMember>
    {
        readonly Dictionary<OpIdentity, ApiMember> Data;

        readonly OpIdentity[] Duplicates;

        [MethodImpl(Inline)]
        public ApiMemberIndex(Dictionary<OpIdentity, ApiMember> index, OpIdentity[] duplicates)
        {
            Data = index;
            Duplicates = duplicates;
        }

        [MethodImpl(Inline)]
        public Option<ApiMember> Lookup(OpIdentity id)
            => Data.TryFind(id);

        public ApiMember this[OpIdentity id]
        {
            [MethodImpl(Inline)]
            get
            {
                if(Data.TryGetValue(id, out var value))
                    return value;
                else
                    return default;
            }
        }

        public int EntryCount
            => Data.Count;

        public IEnumerable<(OpIdentity, ApiMember)> Enumerated
            => Data.Select(kvp => (kvp.Key, kvp.Value));

        public IEnumerable<OpIdentity> Keys
            => Data.Keys;

        public IReadOnlyList<OpIdentity> DuplicateKeys
            => Duplicates;

        IEnumerable<KeyedValue<OpIdentity,ApiMember>> KeyedValues
            => Data.Select(x => KeyedValue.define(x.Key, x.Value));

        public IEnumerator<KeyedValue<OpIdentity, ApiMember>> GetEnumerator()
            => KeyedValues.GetEnumerator();
    }
}