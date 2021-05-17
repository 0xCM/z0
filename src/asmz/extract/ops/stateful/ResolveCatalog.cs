//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial class ApiExtractor
    {
        ReadOnlySpan<ResolvedPart> ResolveCatalog(IApiCatalog src)
        {
            var dst = root.datalist<ResolvedPart>();
            var parts = @readonly(src.Parts);
            var count = parts.Length;
            for(var i=0; i<count; i++)
            {
                dst.Add(ResolvePart(skip(parts,i)));
            }

            return dst.Close();
        }

        ReadOnlySpan<ResolvedPart> ResolveCatalog()
            => ResolveCatalog(Wf.ApiCatalog);
    }
}