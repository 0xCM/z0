//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.SymbolicTest)]

namespace Z0.Parts
{
    public sealed class SymbolicTest : ExecutablePart<SymbolicTest> 
    {
         public override void Execute(params string[] args) => App.Run(args);
    }
}