//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class MklApiTest : ApiPart<MklApiTest>
    {
        const PartId Identity = PartId.MklApiTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}