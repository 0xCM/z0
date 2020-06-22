//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResourceIndex : IResourceIndex
    {
        Dictionary<ulong,BinaryResource> Index {get;}

        public static ResourceIndex Empty 
            => new ResourceIndex(new BinaryResource[]{});

        [MethodImpl(Inline)]
        public static ResourceIndex Create(IResourceProvider src)
            => new ResourceIndex(src.Resources);

        [MethodImpl(Inline)]
        public static implicit operator ResourceIndex(BinaryResource[] src)
            => new ResourceIndex(src);

        internal ResourceIndex(IEnumerable<BinaryResource> src)
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

        void Add(BinaryResource r)        
        {
            if(!Index.TryAdd(r.Address, r))
                throw new Exception($"Duplicated resource id = {r.Identifier}, location = {r.Address}");
        }

        void Merge(ResourceIndex src)
        {
            foreach(var r in src.Indexed)
                Add(r);
        }
    }
}