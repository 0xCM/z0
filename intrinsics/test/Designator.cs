//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class IntrinsicsTest : AssemblyDesignator<IntrinsicsTest>
    {
        const AssemblyId Identity = AssemblyId.IntrinsicsTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}