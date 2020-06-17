//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IApiIndexBuilder
    {
        ApiCodeIndex CreateIndex(ApiHostUri uri, FilePath src);

        ApiCodeIndex CreateIndex(ApiIndex members, OpIndex<UriHex> code);
    }
}