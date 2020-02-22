//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class BitGridsTest : AssemblyDesignator<BitGridsTest>
    {

        const AssemblyId Identity = AssemblyId.BitGridsTest;

        public override AssemblyId Id 
            => Identity;

        public override AssemblyRole Role 
            => AssemblyRole.Test;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}