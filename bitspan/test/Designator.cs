//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public sealed class BitSpanTest : AssemblyResolution<BitSpanTest>
    {
        const AssemblyId Identity = AssemblyId.BitSpanTest;

        public override AssemblyId Id 
            => Identity;
    
        public override void Run(params string[] args)
            => App.Run(args);
    }
}