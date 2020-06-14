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

    public interface IResourceProvider
    {
        IEnumerable<BinaryResource> Resources {get;}

        [MethodImpl(Inline)]
        ResourceIndex CreateIndex()
            => ResourceIndex.Create(this);        
    }
}