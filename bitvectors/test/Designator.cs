//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{        

    public sealed class BitVectorTest : AssemblyResolution<BitVectorTest>
    {

        const AssemblyId Identity = AssemblyId.BitVectorsTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}