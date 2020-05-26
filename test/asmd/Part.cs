//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.AsmDTest)]

namespace Z0.Parts
{
    public sealed class AsmDTest : ExecutablePart<AsmDTest> 
    { 
        public override void Execute(params string[] args) 
            => App.Run(args);                     
    }
}