//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    readonly struct ProvidedResources : IResourceProvider
    {
        public IEnumerable<BinaryResource> Resources => new BinaryResource[]{};


        [MethodImpl(Inline)]
        public ResourceIndex CreateIndex()
            => ResourceIndex.Create(this);        

    }
}