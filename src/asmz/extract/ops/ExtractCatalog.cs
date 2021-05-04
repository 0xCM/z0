//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static memory;

    partial class ApiExtractor
    {
        void ExtractCatalog(IApiCatalog src)
            => ExtractParts(ResolveCatalog(src));
    }
}