//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IBinaryResourceProvider
    {
        IEnumerable<BinaryResource> Resources {get;}
    }

    public class BinaryResources
    {
        public static BinaryResources Empty => Create(new BinaryResource[]{});

        public static BinaryResources Create(IEnumerable<BinaryResource> src)
        {
            var dst = new BinaryResources();
            foreach(var r in src)
               dst.Add(r);
            return dst;
        }   

        public static BinaryResources Create(IBinaryResourceProvider src)
            => Create(src.Resources);

        public static implicit operator BinaryResources(BinaryResource[] src)
            => Create(src);

        BinaryResources()
        {

        }


        Dictionary<ulong,BinaryResource> Index {get;}
            = new Dictionary<ulong, BinaryResource>();

        public IEnumerable<BinaryResource> Indexed
            => Index.Values;

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
            if(!Index.TryAdd(r.Location, r))
                throw new Exception($"Duplicated resource id = {r.Id}, location = {r.Location}");
        }

        public void Merge(BinaryResources src)
        {
            foreach(var r in src.Indexed)
                Add(r);
        }
    }
}