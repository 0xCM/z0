//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Parts
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class FixedTest : ApiResolution<FixedTest>
    {
        const AssemblyId Identity = AssemblyId.FixedTest;

        public override AssemblyId Id 
            => Identity;
    
        public override void Run(params string[] args)
            => App.Run(args);
    }
}