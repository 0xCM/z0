//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.FixedTest)]

namespace Z0.Parts
{        
    public sealed class FixedTest : ExecutablePart<FixedTest>
    {
        public override void Execute(params string[] args) => App.Run(args);
    }
}
