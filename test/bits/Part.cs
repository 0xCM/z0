//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitsTest)]

namespace Z0.Parts
{
    public sealed class BitsTest : ExecutablePart<BitsTest>
    {
        public override void Execute(params string[] args) => BitsTestApp.Run(args);
    }
}