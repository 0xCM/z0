//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Z0.Asm;

    partial class XTend
    {
        public static ICmdRunner<AsmLangCmdKind> AsmLangCmdRunner(this IWfShell wf)
            => AsmLangCmdHost.create(wf);

        public static IntelIntrinsics IntelCpuIntrinsics(this IWfShell wf)
            => IntelIntrinsics.create(wf);

        public static AsmSigs AsmSigs(this IWfShell wf)
            => Z0.Asm.AsmSigs.create(wf);

        public static AsmStatements AsmStatements(this IWfShell wf)
            => Z0.Asm.AsmStatements.create(wf);

        public static AsmCatalogEtl AsmCatalogEtl(this IWfShell wf)
            => Z0.Asm.AsmCatalogEtl.create(wf);

        public static AsmThumbprints AsmThumbprints(this IWfShell wf)
            => Z0.Asm.AsmThumbprints.create(wf);

        public static AsmEltCmdHost AsmEtlCmd(this IWfShell wf)
            => AsmEltCmdHost.create(wf);

        public static AsmFormPipe AsmFormPipe(this IWfShell wf)
            => Z0.Asm.AsmFormPipe.create(wf);

        public static XedInstructionPipe XedPipe(this IWfShell wf)
            => Z0.Asm.XedInstructionPipe.create(wf);

    }
}