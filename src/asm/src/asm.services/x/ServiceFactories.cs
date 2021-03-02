//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    partial class XTend
    {
        public static AsmCatalog AsmCatalog(this IWfShell wf)
            => Z0.Asm.AsmCatalog.create(wf);

        public static AsmSemanticRender AsmSemanticRender(this IWfShell wf)
            => Z0.Asm.AsmSemanticRender.create(wf);

        public static AsmDataEmitter AsmDataEmitter(this IWfShell wf)
            => Z0.Asm.AsmDataEmitter.create(wf);

        public static ResBytesEmitter ResBytesEmitter(this IWfShell wf)
            => Z0.ResBytesEmitter.create(wf);

        public static AsmJmpCollector AsmJmpCollector(this IWfShell wf)
            => Z0.AsmJmpCollector.create(wf);

        public static ApiResCapture ApiResCapture(this IWfShell wf)
            => Z0.ApiResCapture.create(wf);

        public static ApiImmEmitter ImmEmitter(this IWfShell wf)
            => ApiImmEmitter.create(wf);

        public static AsmServices AsmServices(this IWfShell wf)
            => Z0.Asm.AsmServices.create(wf);

        public static ApiCaptureEmitter CaptureEmitter(this IWfShell wf, IAsmContext asm)
            => new ApiCaptureEmitter(wf, asm);

        public static ApiCaptureRunner CaptureRunner(this IWfShell wf)
            => ApiCaptureRunner.create(wf);

        public static IAsmContext AsmContext(this IWfShell wf)
            => Z0.Asm.AsmServices.context(wf);

        public static ApiCaptureService ApiCapture(this IWfShell wf, IAsmContext asm)
            => Z0.Asm.AsmServices.apicapture(wf, asm);

        public static QuickCapture CaptureQuick(this IWfShell wf, IAsmContext asm)
            => Capture.quick(wf,asm);

        public static ICaptureServices CaptureServices(this IWfShell wf, IAsmContext asm)
            => new CaptureServices(wf, asm);

        public static ICaptureCore CaptureCore(this IWfShell wf, IAsmContext asm)
            => Z0.Asm.CaptureCore.create(wf);
    }
}