//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class ResourceProviderAttribute : Attribute
    {

    }

    public readonly struct ResourceProvider : IResourceProvider
    {
        public IEnumerable<BinaryResource> Resources {get;}

        [MethodImpl(Inline)]
        public static IResourceProvider From(IEnumerable<BinaryResource> src)
            => new ResourceProvider(src);

        [MethodImpl(Inline)]
        public ResourceIndex CreateIndex()
            => ResourceIndex.Create(this);        

        [MethodImpl(Inline)]
        ResourceProvider(IEnumerable<BinaryResource> src)
            => Resources = src;
    }
}