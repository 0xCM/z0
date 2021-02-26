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

        public static AsmSemanticRender AsmSemanticRender(this IWfShell wf)
            => Z0.Asm.AsmSemanticRender.create(wf);

        public static AsmDataEmitter AsmDataEmitter(this IWfShell wf)
            => Z0.Asm.AsmDataEmitter.create(wf);

        public static ResBytesEmitter ResBytesEmitter(this IWfShell wf)
            => Z0.ResBytesEmitter.create(wf);

        public static AsmJmpCollector AsmJmpCollector(this IWfShell wf)
            => Z0.AsmJmpCollector.create(wf);

        public static ApiResCapture ApiResCapture(this IWfShell wf)
            => Z0.ApiResCapture.create(wf);
    }
}