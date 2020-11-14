//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmTest)]

namespace Z0.Parts
{
    public sealed class AsmTest : ExecutablePart<AsmTest>
    {
        public override void Execute(params string[] args) => AsmTestApp.Run(args);
    }
}