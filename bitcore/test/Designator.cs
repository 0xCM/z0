//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    public sealed class BitCoreTest : AssemblyDesignator<BitCoreTest>
    {
        const AssemblyId Identity = AssemblyId.BitCoreTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}