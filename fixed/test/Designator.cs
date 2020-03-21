//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class FixedTest : AssemblyResolution<FixedTest>
    {
        const AssemblyId Identity = AssemblyId.FixedTest;

        public override AssemblyId Id 
            => Identity;
    
        public override void Run(params string[] args)
            => App.Run(args);
    }
}