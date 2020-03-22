//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{        
    using System;

    public sealed class VectorizedTest : ApiPart<VectorizedTest>
    {
        const PartId Identity = PartId.VectorizedTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}