//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;

    public sealed class MatrixTest : AssemblyDesignator<MatrixTest>
    {
        const AssemblyId Identity = AssemblyId.MatrixTest;

        public override AssemblyId Id 
            => Identity;

        public override void Run(params string[] args)
            => App.Run(args);
    }
}