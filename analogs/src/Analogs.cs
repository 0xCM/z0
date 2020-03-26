//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Analogs)]

namespace Z0.Parts
{        
    public sealed class Analogs : ApiPart<Analogs, Analogs.C>
    {    
        public class C : ApiCatalog<C> { public C() : base(PartId.Analogs){ }}
    }
}