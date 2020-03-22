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
    public sealed class CoreFuncTest : ApiPart<CoreFuncTest>
    {
        const PartId Identity = PartId.CoreFuncTest;

        public override PartId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);

    }
}