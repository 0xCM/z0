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

    public sealed class AsmCoreTest : AssemblyDesignator<AsmCoreTest>
    {
        public override AssemblyRole Role 
            => AssemblyRole.Test;
    
            public override AssemblyId Id
            => AssemblyId.AsmCoreTest;

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