//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static ICmdRunner<AsmLangCmdKind> AsmLangCmdRunner(this IWfShell wf)
            => AsmLangCmdHost.create(wf);

        [Op]
        public static IntelIntrinsics IntelCpuIntrinsics(this IWfShell wf)
            => IntelIntrinsics.create(wf);

        [Op]
        public static AsmSigs AsmSigs(this IWfShell wf)
            => Asm.AsmSigs.create(wf);

        [Op]
        public static AsmRender AsmRender(this IWfShell wf)
            => Asm.AsmRender.create(wf);

        [Op]
        public static AsmTraverser AsmTraverser(this IWfShell wf)
            => Asm.AsmTraverser.create(wf);

        [Op]
        public static AsmCatalogEtl AsmCatalogEtl(this IWfShell wf)
            => Asm.AsmCatalogEtl.create(wf);

        [Op]
        public static AsmThumbprints AsmThumbprints(this IWfShell wf)
            => Asm.AsmThumbprints.create(wf);

        [Op]
        public static AsmEltCmdHost AsmEtlCmd(this IWfShell wf)
            => AsmEltCmdHost.create(wf);

        [Op]
        public static AsmFormPipe AsmFormPipe(this IWfShell wf)
            => Asm.AsmFormPipe.create(wf);

        [Op]
        public static XedServices Xed(this IWfShell wf)
            => Asm.XedServices.create(wf);

        [Op]
        public static AsmGen AsmCodeGenerator(this IWfShell wf)
            => AsmGen.create(wf);
    }
}