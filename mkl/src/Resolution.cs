//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.MklApi)]

namespace Z0.Parts
{        
    public sealed class MklApi : ApiResolution<MklApi>
    {
        const AssemblyId Identity = AssemblyId.MklApi;
        
        public override AssemblyId Id 
            => Identity;
    }
}