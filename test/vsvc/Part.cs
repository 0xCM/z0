//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VSvcTest)]

namespace Z0.Parts
{
    public sealed class VSvcTest : ExecutablePart<VSvcTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}