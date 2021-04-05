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
        public static AsmFormatter AsmFormatter(this IWfShell wf)
            => Asm.AsmFormatter.create(wf);

        [Op]
        public static AsmDetailPipe AsmDetailPipe(this IWfShell wf)
            => Asm.AsmDetailPipe.create(wf);

        [Op]
        public static AsmEtl AsmEtl(this IWfShell wf)
            => Asm.AsmEtl.create(wf);

        [Op]
        public static ApiCaptureArchive ApiCaptureArchive(this IWfShell wf)
            => Z0.ApiCaptureArchive.create(wf);

        [Op]
        public static ICmdRunner<AsmWfCmdKind> AsmWfCmd(this IWfShell wf)
            => AsmWfCmdHost.create(wf);

        [Op]
        public static AsmCatalog AsmCatalog(this IWfShell wf)
            => Services.AsmCatalog.create(wf);

        [Op]
        public static AsmSemanticRender AsmSemanticRender(this IWfShell wf)
            => Services.AsmSemanticRender.create(wf);

        [Op]
        public static ApiCodeStore ApiCodeStore(this IWfShell wf)
            => Services.ApiCodeStore.create(wf);

        [Op]
        public static AsmRowStore AsmRowStore(this IWfShell wf)
            => Services.AsmRowStore.create(wf);

        [Op]
        public static ApiHostAsmEmitter AsmHostEmitter(this IWfShell wf)
            => new ApiHostAsmEmitter(wf);

        [Op]
        public static ResBytesEmitter ResBytesEmitter(this IWfShell wf)
            => Z0.ResBytesEmitter.create(wf);

        [Op]
        public static AsmJmpPipe AsmJmpPipe(this IWfShell wf)
            => Services.AsmJmpPipe.create(wf);

        [Op]
        public static ApiResCapture ApiResCapture(this IWfShell wf)
            => Services.ApiResCapture.create(wf);

        [Op]
        public static ApiImmEmitter ImmEmitter(this IWfShell wf)
            => ApiImmEmitter.create(wf);

        [Op]
        public static IAsmWriter AsmWriter(this IWfShell wf, FS.FilePath dst)
            => new AsmWriter(dst, wf.AsmFormatter());

        [Op]
        public static AsmServices AsmServices(this IWfShell wf)
            => Services.AsmServices.create(wf);

        [Op]
        public static ApiCaptureEmitter CaptureEmitter(this IWfShell wf)
            => new ApiCaptureEmitter(wf);

        [Op]
        public static ApiCaptureRunner CaptureRunner(this IWfShell wf)
            => ApiCaptureRunner.create(wf);

        [Op]
        public static IAsmContext AsmContext(this IWfShell wf)
            => Services.AsmServices.context(wf);

        [Op]
        public static ApiCaptureService ApiCapture(this IWfShell wf)
            => Z0.ApiCaptureService.create(wf);

        [Op]
        public static QuickCapture CaptureQuick(this IWfShell wf, IAsmContext asm)
            => Capture.quick(wf,asm);

        [Op]
        public static ICaptureServices CaptureServices(this IWfShell wf, IAsmContext asm)
            => new CaptureServices(wf, asm);

        [Op]
        public static ICaptureCore CaptureCore(this IWfShell wf, IAsmContext asm)
            => Services.CaptureCore.create(wf);

        [Op]
        public static ImmSpecializer ImmSpecializer(this IWfShell wf)
            => Z0.Asm.ImmSpecializer.create(wf);

        [Op]
        public static IAsmDecoder AsmDecoder(this IWfShell wf)
            => new AsmRoutineDecoder(wf);

        [Op]
        public static IApiIndexDecoder ApiDecoder(this IWfShell wf)
            => Services.ApiDecoder.create(wf);

        [Op]
        public static AsmDistiller AsmDistiller(this IWfShell wf)
            => Z0.Asm.AsmDistiller.create(wf);

        [Op]
        public static ApiHostDecoder ApiHostDecoder(this IWfShell wf, IAsmDecoder decoder)
            => new ApiHostDecoder(wf, decoder);

        [Op]
        public static AsmStatementPipe AsmStatementPipe(this IWfShell wf)
            => Asm.AsmStatementPipe.create(wf);

        [Op]
        public static ApiCodeBlockTraverser ApiCodeBlockTraverser(this IWfShell src)
            => Asm.ApiCodeBlockTraverser.create(src);

        [Op]
        public static AsmStatementProducer AsmStatementProducer(this IWfShell wf)
            => Asm.AsmStatementProducer.create(wf);

        [Op]
        public static AsmCallPipe AsmCallPipe(this IWfShell wf)
            => Asm.AsmCallPipe.create(wf);
    }
}