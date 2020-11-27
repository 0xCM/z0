//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.PolyrandTest)]

namespace Z0.Parts
{
    public sealed class PolyrandTest : ExecutablePart<PolyrandTest>
    {
        public override void Execute(params string[] args) => PolyrandTestApp.Run(args);
    }
}