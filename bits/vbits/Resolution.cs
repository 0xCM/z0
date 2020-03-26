//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VBits)]

namespace Z0.Parts
{        
    public sealed class VBits : ApiPart<VBits, VBits.C>
    {
        public class C : ApiCatalog<C> { public C() : base(PartId.VBits) { } }
    }
}