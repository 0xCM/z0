//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitGrids)]

namespace Z0.Parts
{        
    public sealed class BitGrids : ApiPart<BitGrids, BitGrids.C>
    {
        public class C : ApiCatalog<C> { public C() : base(PartId.BitGrids) { } }
    }
}