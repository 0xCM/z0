//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VectorsTest)]

namespace Z0.Parts
{        
    using System;

    public sealed class VectorsTest : ExecutablePart<VectorsTest>
    {
        public override void Execute(params string[] args) => App.Run(args);    
    }
}
