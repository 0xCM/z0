//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class LinearOpsTest : AssemblyDesignator<LinearOpsTest>
    {
        public override AssemblyRole Role 
            => AssemblyRole.Test;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}