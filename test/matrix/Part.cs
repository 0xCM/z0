//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MatrixTest)]

namespace Z0.Parts
{        
    using System;

    public sealed class MatrixTest : ExecutablePart<MatrixTest>
    {
        public override void Execute(params string[] args) => App.Run(args);    
    }
}