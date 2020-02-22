//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public sealed class AsmCoreTest : AssemblyDesignator<AsmCoreTest>
    {        
        const AssemblyId Identity = AssemblyId.AsmCoreTest;

        public override AssemblyId Id 
            => Identity;

        public override IEnumerable<IAssemblyDesignator> Designates
            => new IAssemblyDesignator[]{                
                GMath.Designated,
                Intrinsics.Designated, 
                BitCore.Designated,
                BitGrids.Designated,
                Logix.Designated,
                AsmCore.Designated
            };

        public override void Run(params string[] args)
            => App.Run(args);
    }
}