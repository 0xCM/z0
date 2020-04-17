//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.NatsTest)]

namespace Z0.Parts
{        
    public sealed class NatsTest : ExecutablePart<NatsTest>
    {
        public override void Execute(params string[] args) => App.Run(args);    
    }
}