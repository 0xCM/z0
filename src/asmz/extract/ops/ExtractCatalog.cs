//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;

    using Z0.Asm;

    using static memory;

    partial class ApiExtractor
    {
        void ExtractCatalog(IApiCatalog src)
        {
            var resolved = ResolveCatalog(src);
            ExtractParts(resolved);
        }

        public uint ExtractCatalog(IApiCatalog catalog, List<ApiMemberExtract> dst)
        {
            var counter = 0u;
            var parts = @readonly(catalog.Parts);
            var count = parts.Length;

            var flow = Wf.Running(string.Format("Extracting {0} parts", count));
            for(var i=0; i<count; i++)
                counter += ExtractPart(skip(parts,i),dst);

            Wf.Ran(flow, string.Format("Extracted {0} members from {1} parts", counter, count));
            return counter;
        }
    }
}