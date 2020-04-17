//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MemoriesTest)]

namespace Z0.Parts
{
    public sealed class MemoriesTest : ExecutablePart<MemoriesTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}