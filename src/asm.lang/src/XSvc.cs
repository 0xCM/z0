//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Svc = Z0.Asm;

    using P = Z0.Asm.AsmProcessors;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static NasmCatalog NasmCatalog(this IWfRuntime wf)
            => Svc.NasmCatalog.create(wf);


        [Op]
        public static AsmRowPipe AsmRowPipe(this IWfRuntime wf)
            => Svc.AsmRowPipe.create(wf);

        [Op]
        public static StanfordAsmCatalog StanfordCatalog(this IWfRuntime wf)
            => Svc.StanfordAsmCatalog.create(wf);

        [Op]
        public static AsmDbCatalog AsmDbCatalog(this IWfRuntime wf)
            => Svc.AsmDbCatalog.create(wf);

        [Op]
        public static AsmThumbprints AsmThumbprints(this IWfRuntime wf)
            => Svc.AsmThumbprints.create(wf);

        [Op]
        public static AsmFormPipe AsmFormPipe(this IWfRuntime wf)
            => Svc.AsmFormPipe.create(wf);

        [Op]
        public static Svc.AsmModelGen AsmModelGen(this IWfRuntime wf)
            => Svc.AsmModelGen.create(wf);

        [Op]
        public static BdDisasmProcessor DbDiasmProcessor(this IWfRuntime wf)
            => Svc.BdDisasmProcessor.create(wf);

        [Op]
        public static P.DumpBinProcessor DumpBinProcesor(this IWfRuntime wf)
            => P.DumpBinProcessor.create(wf);

        [Op]
        public static AsmToolchain AsmToolchain(this IWfRuntime context)
            => Svc.AsmToolchain.create(context);

        [Op]
        public static AsmDataPipes AsmDataPipes(this IWfRuntime context)
            => Svc.AsmDataPipes.create(context);
    }
}