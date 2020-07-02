//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public readonly struct PartIndex : IEnumerable<IPart>
    {
        readonly Dictionary<PartId,IPart> Parts;

        internal static PartIndex Define(IEnumerable<IPart> parts)        
            => new PartIndex(parts);

        public PartIndex(IEnumerable<IPart> src)
        {
            Parts = new Dictionary<PartId, IPart>();
            foreach(var part in src)
                Parts.TryAdd(part.Id, part);            
        }

        public bool Contains(PartId id)
            => Parts.ContainsKey(id);

        public int PartCount
        {
            get => Parts.Count;
        }
        
        public IEnumerator<IPart> GetEnumerator()
            => Parts.Values.GetEnumerator();

        public Option<IPart> Search(PartId id)
            => Parts.TryGetValue(id, out var part) 
            ? Option.some(part) 
            : Option.none<IPart>();

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}