//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static Seed;

    public interface IUriCodeIndexer
    {
        int Include(params UriCode[] src);   

        int EntryCount {get;}

        ICollection<UriCode> Included {get;}

        UriCodeIndex Freeze();
    }
}