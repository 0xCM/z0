//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Designators
{        
    using System;    

    public sealed class MklApi : AssemblyResolution<MklApi>
    {
        const AssemblyId Identity = AssemblyId.MklApi;
        
        public override AssemblyId Id 
            => Identity;
    }
}