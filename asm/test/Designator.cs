//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Resolutions
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class AsmCoreTest : AssemblyResolution<AsmCoreTest>
    {        
        const AssemblyId Identity = AssemblyId.AsmTest;

        public AsmCoreTest() : base(Identity) {}

        //public override void Run(params string[] args) => App.Run(args);

        // public override IEnumerable<IAssemblyResolution> Designates
        //     => new IAssemblyResolution[]{                
        //         GMath.Resolution,
        //         Intrinsics.Resolution, 
        //         BitCore.Resolution,
        //         BitGrids.Resolution,
        //         Logix.Resolution,
        //         AsmCore.Resolution
        //     };
        
    }
}