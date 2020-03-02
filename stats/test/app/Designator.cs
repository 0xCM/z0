//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class StatsTest : AssemblyResolution<StatsTest>
    {
        const AssemblyId Identity = 0;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args) => App.Run(args);
    }
}