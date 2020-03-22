//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Stats)]

namespace Z0.Parts
{        
    public sealed class Stats : ApiPart<Stats, Stats.C>
    {
        public Stats() : base(PartId.Stats) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Stats) { } }            
    }
}