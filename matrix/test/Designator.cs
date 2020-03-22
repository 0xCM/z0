//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{        
    using System;

    public sealed class MatrixTest : ApiPart<MatrixTest>
    {
        const PartId Identity = PartId.MatrixTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}