//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.SeedTest)]

namespace Z0.Parts
{
    public sealed class SeedTest : ExecutablePart<SeedTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}