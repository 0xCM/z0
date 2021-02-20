//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    partial class XTend
    {
        public static AsmCatalog AsmCatalog(this IWfShell wf)
            => Z0.Asm.AsmCatalog.create(wf);
    }
}