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
    public sealed class RngCoreTest : AssemblyResolution<RngCoreTest>
    {
        const AssemblyId Identity = 0;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);

    }
}