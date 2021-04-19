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
        public static ApiCaptureArchive ApiCaptureArchive(this IWfRuntime wf)
            => Z0.ApiCaptureArchive.create(wf);

        [Op]
        public static ICmdRunner<AsmWfCmdKind> AsmWfCmd(this IWfRuntime wf)
            => AsmWfCmdHost.create(wf);

        [Op]
        public static AsmSemanticRender AsmSemanticRender(this IWfRuntime wf)
            => Services.AsmSemanticRender.create(wf);

        [Op]
        public static AsmRowBuilder AsmRowBuilder(this IWfRuntime wf)
            => Services.AsmRowBuilder.create(wf);

        [Op]
        public static ApiHostAsmEmitter AsmHostEmitter(this IWfRuntime wf)
            => new ApiHostAsmEmitter(wf);

        [Op]
        public static ResBytesEmitter ResBytesEmitter(this IWfRuntime wf)
            => Z0.ResBytesEmitter.create(wf);

        [Op]
        public static AsmJmpPipe AsmJmpPipe(this IWfRuntime wf)
            => Services.AsmJmpPipe.create(wf);

        [Op]
        public static ApiResCapture ApiResCapture(this IWfRuntime wf)
            => Services.ApiResCapture.create(wf);

        [Op]
        public static ApiImmEmitter ImmEmitter(this IWfRuntime wf)
            => ApiImmEmitter.create(wf);

        [Op]
        public static IAsmWriter AsmWriter(this IWfRuntime wf, FS.FilePath dst)
            => new AsmWriter(dst, wf.AsmFormatter());

        [Op]
        public static ApiCaptureEmitter CaptureEmitter(this IWfRuntime wf)
            => new ApiCaptureEmitter(wf);

        [Op]
        public static ApiCaptureRunner CaptureRunner(this IWfRuntime wf)
            => ApiCaptureRunner.create(wf);

        [Op]
        public static IAsmContext AsmContext(this IWfRuntime wf)
            => Services.AsmServices.context(wf);

        [Op]
        public static ApiCaptureService ApiCapture(this IWfRuntime wf)
            => Z0.ApiCaptureService.create(wf);

        [Op]
        public static QuickCapture CaptureQuick(this IWfRuntime wf, IAsmContext asm)
            => Capture.quick(wf, asm);

        [Op]
        public static ICaptureServices CaptureServices(this IWfRuntime wf, IAsmContext asm)
            => new CaptureServices(wf, asm);

        [Op]
        public static ICaptureCore CaptureCore(this IWfRuntime wf, IAsmContext asm)
            => Services.CaptureCore.create(wf);

        [Op]
        public static ImmSpecializer ImmSpecializer(this IWfRuntime wf)
            => Z0.Asm.ImmSpecializer.create(wf);

        [Op]
        public static IAsmDecoder AsmDecoder(this IWfRuntime wf)
            => new AsmRoutineDecoder(wf);

        [Op]
        public static ApiDecoder ApiDecoder(this IWfRuntime wf)
            => Services.ApiDecoder.create(wf);

        [Op]
        public static ApiHostDecoder ApiHostDecoder(this IWfRuntime wf)
            => Asm.ApiHostDecoder.create(wf);

        [Op]
        public static AsmStatementPipe AsmStatementPipe(this IWfRuntime wf)
            => Asm.AsmStatementPipe.create(wf);

        [Op]
        public static ApiCodeBlockTraverser ApiCodeBlockTraverser(this IWfRuntime src)
            => Asm.ApiCodeBlockTraverser.create(src);

        [Op]
        public static AsmStatementProducer AsmStatementProducer(this IWfRuntime wf)
            => Asm.AsmStatementProducer.create(wf);

        [Op]
        public static AsmCallPipe AsmCallPipe(this IWfRuntime wf)
            => Asm.AsmCallPipe.create(wf);
    }
}