//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.DynopsTest)]

namespace Z0.Parts
{        
    public sealed class DynopsTest : ExecutablePart<DynopsTest> 
    { 
        public override void Execute(params string[] args) => App.Run(args);     
    }
}