//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    public sealed class FastOpsTest : AssemblyDesignator<FastOpsTest>
    {
        const AssemblyId Identity = AssemblyId.FastOpsTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}