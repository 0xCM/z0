//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.GMathTest)]

namespace Z0.Parts
{ 
    public sealed class GMathTest : ExecutablePart<GMathTest>
    {
        public override void Execute(params string[] args) => App.Run(args);   
    }
}