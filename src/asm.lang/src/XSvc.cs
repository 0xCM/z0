//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Svc = Z0.Asm;

    [ApiHost]
    public static class XSvc
    {
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
        public static AsmSigs AsmSigs(this IWfRuntime wf)
            => Svc.AsmSigs.create(wf);

        [Op]
        public static AsmThumbprints AsmThumbprints(this IWfRuntime wf)
            => Svc.AsmThumbprints.create(wf);

        [Op]
        public static AsmFormPipe AsmFormPipe(this IWfRuntime wf)
            => Svc.AsmFormPipe.create(wf);

        [Op]
        public static AsmGen AsmCodeGenerator(this IWfRuntime wf)
            => AsmGen.create(wf);

        [Op]
        public static AsmEncoder AsmEncoder(this IWfRuntime wf)
            => Svc.AsmEncoder.create(wf);

        [Op]
        public static AsmParser AsmParser(this IWfRuntime wf)
            => Svc.AsmParser.create(wf);

        [Op]
        public static AsmJumps AsmJumps(this IWfRuntime wf)
            => Svc.AsmJumps.create(wf);

    }
}