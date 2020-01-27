//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using System.Linq;

    public class DataResourceIndex
    {
        public static DataResourceIndex Empty => Create(new DataResource[]{});

        public static DataResourceIndex Create(IEnumerable<DataResource> src)
        {
            var dst = new DataResourceIndex();
            foreach(var r in src)
               dst.Add(r);

            return dst;
        }   

        public static implicit operator DataResourceIndex(DataResource[] src)
            => Create(src);

        DataResourceIndex()
        {

        }

        Dictionary<ulong,DataResource> Index {get;}
            = new Dictionary<ulong, DataResource>();

        public IEnumerable<DataResource> Indexed
            => Index.Values;

        public DataResource? Lookup(ulong location)
        {
            if(Index.TryGetValue(location, out var r))
                return r;
            else
                return null;
        }

        public bool IsEmpty
            => Index.Count == 0;


        void Add(DataResource r)        
        {
            if(!Index.TryAdd(r.Location, r))
                throw new Exception($"Duplicated resource id = {r.Id}, location = {r.Location}");
        }

        public void Merge(DataResourceIndex src)
        {
            foreach(var r in src.Indexed)
                Add(r);

        }
    }
}