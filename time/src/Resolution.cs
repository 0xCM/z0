//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Time)]

namespace Z0.Parts
{        
    public sealed class Time : ApiPart<Time, Time.C>
    {
        public Time() : base(PartId.Time){}

        public class C : ApiCatalog<C> { public C() : base(PartId.Time) { } }
    }    
}