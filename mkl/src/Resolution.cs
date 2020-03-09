//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: AssemblyId(AssemblyId.MklApi)]
namespace Z0.Resolutions
{        
    public sealed class MklApi : AssemblyResolution<MklApi>
    {
        const AssemblyId Identity = AssemblyId.MklApi;
        
        public override AssemblyId Id 
            => Identity;
    }
}