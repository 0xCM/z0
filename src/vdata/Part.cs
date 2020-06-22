//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.VData)]

namespace Z0.Parts
{
    using System;
    using System.Collections.Generic;

    public sealed class VData : Part<VData>, IResourceProvider
    {        
        public IEnumerable<BinaryResource> Resources 
            => Root.seq<BinaryResource>();
    }
}