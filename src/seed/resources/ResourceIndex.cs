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

    public readonly struct BinaryResourceIndex : IBinaryResourceIndex
    {
        readonly Dictionary<ulong,BinaryResource> Index;

        [MethodImpl(Inline)]
        public static BinaryResourceIndex Create(IResourceProvider src)
            => new BinaryResourceIndex(src.Resources);

        [MethodImpl(Inline)]
        public static implicit operator BinaryResourceIndex(BinaryResource[] src)
            => new BinaryResourceIndex(src);

        internal BinaryResourceIndex(IEnumerable<BinaryResource> src)
        {
            Index = new Dictionary<ulong, BinaryResource>();            
            foreach(var r in src)
               Add(r);
        }
            
        public IEnumerable<BinaryResource> Indexed
            => Index.Values;

        [MethodImpl(Inline)]
        public BinaryResource? Lookup(ulong location)
        {
            if(Index.TryGetValue(location, out var r))
                return r;
            else
                return null;
        }

        public bool IsEmpty
            => Index.Count == 0;

        public BinaryResource[] Content 
            => Index.Values.ToArray();

        void Add(BinaryResource r)        
        {
            if(!Index.TryAdd(r.Address, r))
                throw new Exception($"Duplicated resource id = {r.Identifier}, location = {r.Address}");
        }

        void Merge(BinaryResourceIndex src)
        {
            foreach(var r in src.Indexed)
                Add(r);
        }

        public static BinaryResourceIndex Empty 
            => new BinaryResourceIndex(Array.Empty<BinaryResource>());

    }
}