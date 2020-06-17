//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ProvidedResources : IResourceProvider
    {
        public IEnumerable<BinaryResource> Resources 
            => new BinaryResource[]{};

        [MethodImpl(Inline)]
        public ResourceIndex CreateIndex()
            => ResourceIndex.Create(this);        
    }
}