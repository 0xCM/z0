//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    public sealed class LibMTest : ApiResolution<LibMTest>
    {
        const AssemblyId Identity = AssemblyId.LibMTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}