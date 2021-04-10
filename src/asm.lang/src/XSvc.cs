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
        public static ICmdRunner<AsmLangCmdKind> AsmLangCmdRunner(this IWfRuntime wf)
            => AsmLangCmdHost.create(wf);

        [Op]
        public static IntelIntrinsics IntelCpuIntrinsics(this IWfRuntime wf)
            => IntelIntrinsics.create(wf);

        [Op]
        public static AsmSigs AsmSigs(this IWfRuntime wf)
            => Asm.AsmSigs.create(wf);

        [Op]
        public static AsmRender AsmRender(this IWfRuntime wf)
            => Asm.AsmRender.create(wf);

        [Op]
        public static AsmTraverser AsmTraverser(this IWfRuntime wf)
            => Asm.AsmTraverser.create(wf);

        [Op]
        public static AsmCatalogEtl AsmCatalogEtl(this IWfRuntime wf)
            => Asm.AsmCatalogEtl.create(wf);

        [Op]
        public static AsmThumbprints AsmThumbprints(this IWfRuntime wf)
            => Asm.AsmThumbprints.create(wf);

        [Op]
        public static AsmEltCmdHost AsmEtlCmd(this IWfRuntime wf)
            => AsmEltCmdHost.create(wf);

        [Op]
        public static AsmFormPipe AsmFormPipe(this IWfRuntime wf)
            => Asm.AsmFormPipe.create(wf);

        [Op]
        public static XedServices Xed(this IWfRuntime wf)
            => Asm.XedServices.create(wf);

        [Op]
        public static AsmGen AsmCodeGenerator(this IWfRuntime wf)
            => AsmGen.create(wf);

        [Op]
        public static AsmDb AsmDb(this IWfRuntime wf)
            => Asm.AsmDb.create(wf);
    }
}