//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.MklApi)]

namespace Z0.Parts
{        
    public sealed class MklApi : ApiPart<MklApi>
    {
        const PartId Identity = PartId.MklApi;
        
        public override PartId Id 
            => Identity;
    }
}