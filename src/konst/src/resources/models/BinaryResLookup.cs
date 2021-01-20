//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Part;

    public readonly struct BinaryResLookup : IBinaryResLookup
    {
        readonly Dictionary<ulong,BinaryRes> Index;

        public readonly BinaryRes[] Ordered;

        [MethodImpl(Inline)]
        public static implicit operator BinaryResLookup(BinaryRes[] src)
            => new BinaryResLookup(src);

        [MethodImpl(Inline)]
        internal BinaryResLookup(IEnumerable<BinaryRes> src)
        {
            Index = new Dictionary<ulong,BinaryRes>();
            Ordered = Array.Empty<BinaryRes>();

            foreach(var r in src)
               Add(r);

            Ordered = Index.Values.OrderBy(x => x.Address).ToArray();
        }

        [MethodImpl(Inline)]
        public BinaryRes? Search(ulong location)
        {
            if(Index.TryGetValue(location, out var r))
                return r;
            else
                return null;
        }

        public BinaryRes? Search(string id)
        {
            for(var i=0; i< Content.Length; i++)
            {
                var res = Content[i];
                if(res.Identifier == id)
                    return res;
            }
            return null;
        }

        public bool IsEmpty
            => Index.Count == 0;

        public ReadOnlySpan<BinaryRes> View
        {
            [MethodImpl(Inline)]
            get => Ordered;
        }

        public BinaryRes[] Content
            => Index.Values.ToArray();

        void Add(BinaryRes r)
        {
            if(!Index.TryAdd(r.Address, r))
                throw new Exception($"Duplicated resource id = {r.Identifier}, location = {r.Address}");
        }

        public static BinaryResLookup Empty
            => new BinaryResLookup(Array.Empty<BinaryRes>());
    }
}