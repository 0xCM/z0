//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VData)]

namespace Z0.Parts
{
    using System;
    using System.Collections.Generic;

    public sealed class VData : Part<VData>
    {        
        public override IPartData ResourceProvider => default(ProvidedResources);   
        
    }

    readonly struct ProvidedResources : IPartData
    {
        public IEnumerable<BinaryResource> Resources => Data.Resources;
    }
}