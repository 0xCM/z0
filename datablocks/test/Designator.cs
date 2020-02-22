//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public sealed class DataBlocksTest : AssemblyDesignator<DataBlocksTest>
    {
        const AssemblyId Identity = AssemblyId.DataBlocksTest;

        public override AssemblyId Id 
            => Identity;

        public override AssemblyRole Role 
            => AssemblyRole.Test;
    
        public override void Run(params string[] args)
            => App.Run(args);
    }
}