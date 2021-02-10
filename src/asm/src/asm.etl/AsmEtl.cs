//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct AsmEtl
    {
        public static AsmCatalogEtl catalog(IWfShell wf)
            => AsmCatalogEtl.create(wf);
    }
}