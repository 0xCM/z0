//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
 
    public sealed class GMathTest : AssemblyResolution<GMathTest>
    {
        const AssemblyId Identity = AssemblyId.GeneriNumericsTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}