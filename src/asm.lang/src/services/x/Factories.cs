//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Xml;

    using Z0.Asm;

    partial class XTend
    {
        public static IWfCmdHost<AsmSigCmdKind> AsmSigCmd(this IWfShell wf)
            => AsmSigCmdHost.create(wf);

        public static IntelIntrinsics IntelCpuIntrinsics(this IWfShell wf)
            => IntelIntrinsics.create(wf);

        public static AsmSigs AsmSigs(this IWfShell wf)
            => Z0.Asm.AsmSigs.create(wf);

        public static AsmCatalogEtl AsmCatalogEtl(this IWfShell wf)
            => Z0.Asm.AsmCatalogEtl.create(wf);
    }
}