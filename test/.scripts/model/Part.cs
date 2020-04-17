//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.ModelTest)]

namespace Z0.Parts
{
    public sealed class ModelTest : ExecutablePart<ModelTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}