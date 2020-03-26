//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{
    using System;

    public sealed class FixedTest : ApiPart<FixedTest>
    {
        const PartId Identity = PartId.FixedTest;

        public override PartId Id 
            => Identity;
    
        public override void Run(params string[] args)
            => App.Run(args);
    }
}