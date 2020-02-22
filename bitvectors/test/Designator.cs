//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        

    /// <summary>
    /// Represents the assembly
    /// </summary>
    public sealed class BitVectorTest : AssemblyDesignator<BitVectorTest>
    {

        const AssemblyId Identity = AssemblyId.BitVectorsTest;

        public override AssemblyId Id 
            => Identity;

        public override AssemblyRole Role 
            => AssemblyRole.Test;

        public override void Run(params string[] args)
            => App.Run(args);

    }

}