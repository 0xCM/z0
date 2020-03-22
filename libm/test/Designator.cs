//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{        
    using System;

    public sealed class LibMTest : ApiPart<LibMTest>
    {
        const PartId Identity = PartId.LibMTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}