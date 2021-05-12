//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Services = Z0.Asm;

    public static class XSvc
    {
        [Op]
        public static AsmFormatter AsmFormatter(this IWfRuntime wf)
            => Services.AsmFormatter.create(wf);

        [Op]
        public static AsmEtl AsmEtl(this IWfRuntime wf)
            => Services.AsmEtl.create(wf);

        [Op]
        public static AsmSemanticRender AsmSemanticRender(this IWfRuntime wf)
            => Services.AsmSemanticRender.create(wf);

        [Op]
        public static AsmRowBuilder AsmRowBuilder(this IWfRuntime wf)
            => Services.AsmRowBuilder.create(wf);

        [Op]
        public static ApiHostAsmEmitter AsmHostEmitter(this IWfRuntime wf)
            => Services.ApiHostAsmEmitter.create(wf);

        [Op]
        public static ResPackEmitter ResPackEmitter(this IWfRuntime wf)
            => Services.ResPackEmitter.create(wf);

        [Op]
        public static ResPackUnpacker ResPackUnpacker(this IWfRuntime wf)
            => Services.ResPackUnpacker.create(wf);

        [Op]
        public static AsmJmpPipe AsmJmpPipe(this IWfRuntime wf)
            => Services.AsmJmpPipe.create(wf);

        [Op]
        public static IAsmWriter AsmWriter(this IWfRuntime wf, FS.FilePath dst)
            => new AsmWriter(dst, wf.AsmFormatter());

        [Op]
        public static AsmImmWriter ImmWriter(this IWfRuntime wf, in ApiHostUri host)
            => new AsmImmWriter(wf, host, wf.AsmFormatter());

        [Op]
        public static AsmImmWriter ImmWriter(this IWfRuntime wf, in ApiHostUri host, AsmFormatter formatter)
            => new AsmImmWriter(wf, host, formatter);

        [Op]
        public static AsmDecoder AsmDecoder(this IWfRuntime wf)
            => Services.AsmDecoder.create(wf);

        [Op]
        public static AsmBitstringEmitter AsmBitstringEmitter(this IWfRuntime wf)
            => Services.AsmBitstringEmitter.create(wf);

        [Op]
        public static AsmStatementPipe AsmStatementPipe(this IWfRuntime wf)
            => Services.AsmStatementPipe.create(wf);

        [Op]
        public static ApiCodeBlockTraverser ApiCodeBlockTraverser(this IWfRuntime src)
            => Services.ApiCodeBlockTraverser.create(src);

        [Op]
        public static AsmCallPipe AsmCallPipe(this IWfRuntime wf)
            => Services.AsmCallPipe.create(wf);

        [Op]
        public static AsmCommands AsmCommands(this IWfRuntime wf)
            => Services.AsmCommands.create(wf);
    }
}