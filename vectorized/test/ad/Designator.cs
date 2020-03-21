//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        
    using System;

    public sealed class VectorizedTest : ApiResolution<VectorizedTest>
    {
        const AssemblyId Identity = AssemblyId.VectorizedTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}