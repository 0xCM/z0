//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Z0.Asm;

    using Services = Z0.Asm;

    partial class XTend
    {
        public static AsmDetailPipe AsmDetailPipe(this IWfShell wf)
            => Asm.AsmDetailPipe.create(wf);

        public static AsmEtl AsmRowEtl(this IWfShell wf)
            => AsmEtl.create(wf);

        public static ICmdRunner<AsmWfCmdKind> AsmWfCmd(this IWfShell wf)
            => AsmWfCmdHost.create(wf);

        public static AsmCatalog AsmCatalog(this IWfShell wf)
            => Services.AsmCatalog.create(wf);

        public static AsmSemanticRender AsmSemanticRender(this IWfShell wf)
            => Services.AsmSemanticRender.create(wf);

        public static ApiCodeStore ApiCodeStore(this IWfShell wf)
            => Services.ApiCodeStore.create(wf);

        public static AsmRowStore AsmRowStore(this IWfShell wf)
            => Services.AsmRowStore.create(wf);

        [Op]
        public static ApiHostAsmEmitter AsmHostEmitter(this IWfShell wf, IAsmContext asm)
            => new ApiHostAsmEmitter(wf, asm);

        public static ResBytesEmitter ResBytesEmitter(this IWfShell wf)
            => Z0.ResBytesEmitter.create(wf);

        public static AsmJmpCollector AsmJmpCollector(this IWfShell wf)
            => Services.AsmJmpCollector.create(wf);

        public static ApiResCapture ApiResCapture(this IWfShell wf)
            => Services.ApiResCapture.create(wf);

        public static ApiImmEmitter ImmEmitter(this IWfShell wf)
            => ApiImmEmitter.create(wf);

        public static IAsmWriter AsmWriter(this IWfShell wf, FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, new AsmRoutineFormatter(config));

        public static AsmServices AsmServices(this IWfShell wf)
            => Services.AsmServices.create(wf);

        public static ApiCaptureEmitter CaptureEmitter(this IWfShell wf, IAsmContext asm)
            => new ApiCaptureEmitter(wf, asm);

        public static ApiCaptureRunner CaptureRunner(this IWfShell wf)
            => ApiCaptureRunner.create(wf);

        public static IAsmContext AsmContext(this IWfShell wf)
            => Services.AsmServices.context(wf);

        public static ApiCaptureService ApiCapture(this IWfShell wf)
            => Z0.ApiCaptureService.create(wf);

        public static QuickCapture CaptureQuick(this IWfShell wf, IAsmContext asm)
            => Capture.quick(wf,asm);

        public static ICaptureServices CaptureServices(this IWfShell wf, IAsmContext asm)
            => new CaptureServices(wf, asm);

        public static ICaptureCore CaptureCore(this IWfShell wf, IAsmContext asm)
            => Services.CaptureCore.create(wf);

        public static ImmSpecializer ImmSpecializer(this IWfShell wf)
            => Z0.Asm.ImmSpecializer.create(wf);

        public static IAsmDecoder AsmDecoder(this IWfShell wf, in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        public static IAsmDecoder AsmDecoder(this IWfShell wf)
            => new AsmRoutineDecoder(AsmFormatConfig.DefaultStreamFormat);

        public static IApiIndexDecoder ApiIndexDecoder(this IWfShell wf)
            => Services.ApiIndexDecoder.create(wf);

        public static AsmDistiller AsmDistiller(this IWfShell wf)
            => Z0.Asm.AsmDistiller.create(wf);

        public static ApiHostDecoder ApiHostDecoder(this IWfShell wf, IAsmDecoder decoder)
            => new ApiHostDecoder(wf, decoder);

        public static AsmStatementPipe AsmStatementPipe(this IWfShell wf)
            => Asm.AsmStatementPipe.create(wf);

        public static ApiCodeBlockTraverser ApiiCodeBlockTraverser(this IWfShell src)
            => Asm.ApiCodeBlockTraverser.create(src);
    }
}