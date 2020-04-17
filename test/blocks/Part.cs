//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BlocksTest)]

namespace Z0.Parts
{
    public sealed class BlocksTest : ExecutablePart<BlocksTest> 
    {
        public override void Execute(params string[] args) => App.Run(args);        
    } 
}