//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VSvc)]

namespace Z0.Parts
{
    public sealed class VSvc : ApiPart<VSvc, VSvc.C>
    {        
        public class C : ApiCatalog<C> { public C() : base(PartId.VSvc) { } }
    }
}