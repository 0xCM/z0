//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.PermuteTest)]

namespace Z0.Parts
{
    public sealed class PermuteTest : ExecutablePart<PermuteTest> 
    {
        public override void Execute(params string[] args) => App.Run(args);             
    }
}