//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static core;

    partial class ApiExtractor
    {
        uint ExtractCatalogs(ReadOnlySpan<IApiPartCatalog> src)
        {
            var counter = 0u;
            var count = src.Length;
            var dst = root.list<ApiHostDataset>();
            for(var i=0; i<count; i++)
                counter += ExtractCatalog(skip(src,i));
            return counter;
        }
    }
}