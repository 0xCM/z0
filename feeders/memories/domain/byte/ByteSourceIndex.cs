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

    public class ByteSourceIndex
    {
        public static ByteSourceIndex Empty => Create(new ByteSource[]{});

        public static ByteSourceIndex Create(IEnumerable<ByteSource> src)
        {
            var dst = new ByteSourceIndex();
            foreach(var r in src)
               dst.Add(r);
            return dst;
        }   

        public static implicit operator ByteSourceIndex(ByteSource[] src)
            => Create(src);

        ByteSourceIndex()
        {

        }

        Dictionary<ulong,ByteSource> Index {get;}
            = new Dictionary<ulong, ByteSource>();

        public IEnumerable<ByteSource> Indexed
            => Index.Values;

        public ByteSource? Lookup(ulong location)
        {
            if(Index.TryGetValue(location, out var r))
                return r;
            else
                return null;
        }

        public bool IsEmpty
            => Index.Count == 0;

        void Add(ByteSource r)        
        {
            if(!Index.TryAdd(r.Location, r))
                throw new Exception($"Duplicated resource id = {r.Id}, location = {r.Location}");
        }

        public void Merge(ByteSourceIndex src)
        {
            foreach(var r in src.Indexed)
                Add(r);
        }
    }
}