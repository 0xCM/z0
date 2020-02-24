//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class AsmCoreTest : AssemblyResolution<AsmCoreTest>
    {        
        const AssemblyId Identity = AssemblyId.AsmCoreTest;

        public override AssemblyId Id 
            => Identity;

        public override IEnumerable<IAssemblyResolution> Designates
            => new IAssemblyResolution[]{                
                GMath.Resolution,
                Intrinsics.Resolution, 
                BitCore.Resolution,
                BitGrids.Resolution,
                Logix.Resolution,
                AsmCore.Resolution
            };

        public override void Run(params string[] args)
            => App.Run(args);
    }
}