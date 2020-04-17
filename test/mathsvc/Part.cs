//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MathSvcTest)]

namespace Z0.Parts
{
    public sealed class MathSvcTest : ExecutablePart<MathSvcTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}