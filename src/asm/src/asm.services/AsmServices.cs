//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public sealed class AsmServices : IAsmServices
    {
        [Op]
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);

        [Op]
        public static IAsmWf workflow(IWfShell wf)
            => new AsmWf(wf, context(wf));

        [Op]
        public static IAsmServices init(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        [Op]
        public static IAsmDecoder Decoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        [Op]
        public static ApiCaptureService ApiCapture(IWfShell wf, IAsmContext asm)
            => new ApiCaptureService(wf, asm);

        [Op]
        public static ApiCaptureService ApiCapture(IAsmWf wf)
            => new ApiCaptureService(wf.Wf, wf.Asm);

        [Op]
        public static IApiResCapture ResCapture(IWfShell wf)
            => ApiResCapture.create(wf);

        [Op]
        public static IApiHostCapture HostCapture(IWfShell wf)
            => ApiHostCapture.create(wf);

        public static IAsmDataEmitter DataEmitter(IWfShell wf)
            => AsmDataEmitter.create(wf);

        [Op]
        public static ApiHostDecoder HostDecoder(IWfShell wf, IAsmDecoder decoder)
            => new ApiHostDecoder(wf, decoder);

        [Op]
        public static ApiHostAsmEmitter HostEmitter(IWfShell wf, IAsmContext asm)
            => new ApiHostAsmEmitter(wf, asm);


        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IApiAsmProcessor ApiProcessor(IWfShell wf)
        {
            var processor = new WfAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static IAsmWriter Writer(FS.FilePath dst)
            => new AsmWriter(dst, Formatter());

        [MethodImpl(Inline), Op]
        public static IAsmWriter Writer(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, Formatter(config));

        [MethodImpl(Inline), Op]
        public static IAsmFormatter Formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        [MethodImpl(Inline), Op]
        public static IAsmFormatter Formatter()
            => new AsmFormatter(null);

        [MethodImpl(Inline), Op]
        public static IAsmWriter Writer(FS.FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst,formatter);

        [MethodImpl(Inline), Op]
        public static ICaptureExchange Exchange(ICaptureCore service, BufferToken capture)
            => new CaptureExchangeProxy(service, capture);

        [MethodImpl(Inline), Op]
        public static ICaptureAlt CaptureAlt(IWfShell wf, IAsmContext asm)
            => Capture.alt(wf,asm);

        [Op]
        public static QuickCapture CaptureQuick(IWfShell wf, IAsmContext asm)
        {
            var tokens = Buffers.sequence(asm.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = Exchange(asm.CaptureCore, tokens[BufferSeqId.Aux3]);
            var service = new CaptureServiceProxy(asm.CaptureCore, exchange);
            return new QuickCapture(wf, asm, buffer, tokens, service);
        }

        IWfShell Wf {get;}

        IAsmContext Asm {get;}

        [MethodImpl(Inline)]
        AsmServices(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        public ICaptureAlt Alt()
            => CaptureAlt(Wf, Asm);

        public IAsmDecoder Decoder()
            => new AsmRoutineDecoder(Asm.FormatConfig);

        public IAsmImmWriter ImmWriter(ApiHostUri host, FS.FolderPath dst)
            => new AsmImmWriter(host, Asm.Formatter, dst);

        public AsmSemanticRender SemanticRender()
            => new AsmSemanticRender(Wf);

        public IAsmImmWriter ImmWriter(ApiHostUri host)
            => ImmWriter(host, Wf.Db().ImmRoot());
    }
}