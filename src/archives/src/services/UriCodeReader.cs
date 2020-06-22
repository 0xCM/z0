//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;


    public readonly struct UriCodeReader : IMemberCodeReader
    {
        public static IMemberCodeReader Service => default(UriCodeReader);

        public IEnumerable<MemberCode> Read(FilePath src)
            => throw new NotImplementedException();
    }
}