//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.Blocks)]

namespace Z0.Parts
{        
    public sealed class Blocks : ApiPart<Blocks, Blocks.C>
    {
        public Blocks() : base(PartId.Blocks) {}

        public class C : ApiCatalog<C> { public C() : base(PartId.Blocks){ }}
    }
}