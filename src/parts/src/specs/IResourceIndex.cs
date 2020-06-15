//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IResourceIndex
    {
        IEnumerable<BinaryResource> Indexed {get;}

        BinaryResource? Lookup(ulong location);

        bool IsEmpty {get;}
    }
}