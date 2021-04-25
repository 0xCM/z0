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
            => Asm.AsmFormatter.create(wf);

        [Op]
        public static AsmEtl AsmEtl(this IWfRuntime wf)
            => Asm.AsmEtl.create(wf);

        [Op]
        public static AsmSemanticRender AsmSemanticRender(this IWfRuntime wf)
            => Services.AsmSemanticRender.create(wf);

        [Op]
        public static AsmRowBuilder AsmRowBuilder(this IWfRuntime wf)
            => Services.AsmRowBuilder.create(wf);

        [Op]
        public static ApiHostAsmEmitter AsmHostEmitter(this IWfRuntime wf)
            => Asm.ApiHostAsmEmitter.create(wf);

        [Op]
        public static ResBytesEmitter ResBytesEmitter(this IWfRuntime wf)
            => Z0.ResBytesEmitter.create(wf);

        [Op]
        public static AsmJmpPipe AsmJmpPipe(this IWfRuntime wf)
            => Services.AsmJmpPipe.create(wf);

        [Op]
        public static IAsmWriter AsmWriter(this IWfRuntime wf, FS.FilePath dst)
            => new AsmWriter(dst, wf.AsmFormatter());

        [Op]
        public static IAsmImmWriter ImmWriter(this IWfRuntime wf, in ApiHostUri host)
            => new AsmImmWriter(wf, host, wf.AsmFormatter());

        [Op]
        public static IAsmImmWriter ImmWriter(this IWfRuntime wf, in ApiHostUri host, AsmFormatter formatter)
            => new AsmImmWriter(wf, host, formatter);

        [Op]
        public static AsmRoutineDecoder AsmDecoder(this IWfRuntime wf)
            => new AsmRoutineDecoder(wf);

        [Op]
        public static ApiDecoder ApiDecoder(this IWfRuntime wf)
            => Services.ApiDecoder.create(wf);

        [Op]
        public static ApiHostDecoder ApiHostDecoder(this IWfRuntime wf)
            => Asm.ApiHostDecoder.create(wf);

        [Op]
        public static AsmBitstringEmitter AsmBitstringEmitter(this IWfRuntime wf)
            => Asm.AsmBitstringEmitter.create(wf);

        [Op]
        public static AsmStatementPipe AsmStatementPipe(this IWfRuntime wf)
            => Asm.AsmStatementPipe.create(wf);

        [Op]
        public static ApiCodeBlockTraverser ApiCodeBlockTraverser(this IWfRuntime src)
            => Asm.ApiCodeBlockTraverser.create(src);


        [Op]
        public static AsmCallPipe AsmCallPipe(this IWfRuntime wf)
            => Asm.AsmCallPipe.create(wf);
    }
}