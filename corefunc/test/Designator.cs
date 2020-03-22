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
    public sealed class CoreFuncTest : ApiResolution<CoreFuncTest>
    {
        const AssemblyId Identity = AssemblyId.CoreFuncTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);

    }
}