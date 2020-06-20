//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;


    public readonly struct UriCodeReader : IUriCodeReader
    {
        public static IUriCodeReader Service => default(UriCodeReader);

        public IEnumerable<UriCode> Read(FilePath src)
            => throw new NotImplementedException();
    }
}
