//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.GVecTest)]

namespace Z0.Parts
{
    public sealed class GVecTest : ExecutablePart<GVecTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}