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
        public static IAsmDecoder decoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        [Op]
        public static ApiCaptureService ApiCapture(IWfShell wf, IAsmContext asm)
            => new ApiCaptureService(wf, asm);

        [Op]
        public static ApiCaptureService ApiCapture(IAsmWf wf)
            => new ApiCaptureService(wf.Wf, wf.Asm);

        [Op]
        public static ApiHostDecoder HostDecoder(IWfShell wf, IAsmDecoder decoder)
            => new ApiHostDecoder(wf, decoder);

        [Op]
        public static ApiHostDecoder HostDecoder(IAsmWf wf)
            => new ApiHostDecoder(wf.Wf, wf.Decoder);

        [Op]
        public static ApiHostAsmEmitter HostEmitter(IWfShell wf, IAsmContext asm)
            => new ApiHostAsmEmitter(wf, asm);

        [Op]
        public static ApiHostAsmEmitter HostEmitter(IAsmWf wf)
            => new ApiHostAsmEmitter(wf.Wf, wf.Asm);

        [Op]
        public static IApiHostCapture HostCapture(IWfShell wf)
            => ApiHostCapture.create(wf);

        /// <summary>
        /// Creates an asm processor
        /// </summary>
        /// <param name="context">The process context</param>
        [MethodImpl(Inline), Op]
        public static IApiAsmProcessor processor(IWfShell wf)
        {
            var processor = new WfAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static IAsmWriter writer(FS.FilePath dst)
            => new AsmWriter(dst, formatter());

        [MethodImpl(Inline), Op]
        public static IAsmWriter writer(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, formatter(config));

        [MethodImpl(Inline), Op]
        public static IAsmFormatter formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        [MethodImpl(Inline), Op]
        public static IAsmFormatter formatter()
            => new AsmFormatter(null);

        [MethodImpl(Inline), Op]
        public static IAsmWriter writer(FS.FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst,formatter);

        [MethodImpl(Inline), Op]
        public static ICaptureExchange exchange(ICaptureCore service, BufferToken capture)
            => new CaptureExchangeProxy(service, capture);

        [MethodImpl(Inline), Op]
        public static ICaptureServiceProxy capture(ICaptureCore service, ICaptureExchange exchange)
            => new CaptureServiceProxy(service, exchange);

        [MethodImpl(Inline), Op]
        public static ICaptureAlt alt(IWfShell wf, IAsmContext asm)
            => Capture.alt(wf,asm);

        [Op]
        public static QuickCapture quick(IAsmContext asm)
        {
            var tokens = Buffers.sequence(asm.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = AsmServices.exchange(asm.CaptureCore, tokens[BufferSeqId.Aux3]);
            var service = AsmServices.capture(asm.CaptureCore, exchange);
            return new QuickCapture(asm, buffer, tokens, service);
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
            => alt(Wf, Asm);

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