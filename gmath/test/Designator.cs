//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
 
    public sealed class GMathTest : AssemblyDesignator<GMathTest>
    {
        const AssemblyId Identity = AssemblyId.GMathTest;

        public override AssemblyId Id 
            => Identity;

        public override AssemblyRole Role 
            => AssemblyRole.Test;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}