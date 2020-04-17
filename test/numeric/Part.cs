//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.NumericTest)]

namespace Z0.Parts
{
    public sealed class NumericTest : ExecutablePart<NumericTest> 
    {
        public override void Execute(params string[] args) => App.Run(args);            
    } 
}