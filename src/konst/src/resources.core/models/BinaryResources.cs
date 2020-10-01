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

    using static Konst;

    public readonly struct BinaryResources : IBinaryResourceIndex
    {
        readonly Dictionary<ulong,BinaryResource> Index;

        public readonly BinaryResource[] Ordered;

        [MethodImpl(Inline)]
        public static implicit operator BinaryResources(BinaryResource[] src)
            => new BinaryResources(src);

        [MethodImpl(Inline)]
        internal BinaryResources(IEnumerable<BinaryResource> src)
        {
            Index = new Dictionary<ulong,BinaryResource>();
            Ordered = Array.Empty<BinaryResource>();

            foreach(var r in src)
               Add(r);

            Ordered = Index.Values.OrderBy(x => x.Address).ToArray();
        }

        [MethodImpl(Inline)]
        public BinaryResource? Search(ulong location)
        {
            if(Index.TryGetValue(location, out var r))
                return r;
            else
                return null;
        }

        public BinaryResource? Search(string id)
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

        public ReadOnlySpan<BinaryResource> View
        {
            [MethodImpl(Inline)]
            get => Ordered;
        }

        public BinaryResource[] Content
            => Index.Values.ToArray();

        void Add(BinaryResource r)
        {
            if(!Index.TryAdd(r.Address, r))
                throw new Exception($"Duplicated resource id = {r.Identifier}, location = {r.Address}");
        }

        public static BinaryResources Empty
            => new BinaryResources(Array.Empty<BinaryResource>());
    }
}