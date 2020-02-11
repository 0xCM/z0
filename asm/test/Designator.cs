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
    
        public override IEnumerable<IAssemblyDesignator> Designates
            => items<IAssemblyDesignator>(
                Intrinsics.Designated, 
                GMath.Designated,
                BitCore.Designated
                );
        public override void Run(params string[] args)
            => App.Run(args);
    }
}