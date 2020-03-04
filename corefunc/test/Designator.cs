//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class CoreFuncTest : AssemblyResolution<CoreFuncTest>
    {
        const AssemblyId Identity = AssemblyId.CoreFuncTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);

    }
}