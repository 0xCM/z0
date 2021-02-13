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
        public static AsmServices create(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        [Op]
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);

        [Op]
        public static AsmServices create(IWfShell wf)
            => new AsmServices(wf, context(wf));

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
        public static ApiCaptureService apicapture(IWfShell wf, IAsmContext asm)
            => new ApiCaptureService(wf, asm);

        [Op]
        public static IApiResCapture ResCapture(IWfShell wf)
            => ApiResCapture.create(wf);

        [Op]
        public static IApiHostCapture HostCapture(IWfShell wf)
            => ApiHostCapture.create(wf);


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
            var processor = new ApiAsmProcessor(wf) as IApiAsmProcessor;
            processor.Connect();
            return processor;
        }

        [MethodImpl(Inline), Op]
        public static IAsmWriter writer(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, formatter(config));

        [MethodImpl(Inline), Op]
        public static IAsmFormatter formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        [MethodImpl(Inline), Op]
        public static IAsmWriter writer(FS.FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst,formatter);

        [MethodImpl(Inline), Op]
        public static ICaptureExchange exchange(ICaptureCore service, BufferToken capture)
            => new CaptureExchangeProxy(service, capture);

        [Op]
        public static QuickCapture CaptureQuick(IWfShell wf, IAsmContext asm)
        {
            var tokens = Buffers.sequence(asm.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = AsmServices.exchange(asm.CaptureCore, tokens[BufferSeqId.Aux3]);
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

        public IAsmDecoder RoutineDecoder()
            => new AsmRoutineDecoder(Asm.FormatConfig);

        public IAsmDecoder RoutineDecoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        public IApiIndexDecoder IndexDecoder()
            => ApiIndexDecoder.create(Wf);

        public IAsmImmWriter ImmWriter(ApiHostUri host, FS.FolderPath dst)
            => new AsmImmWriter(host, Asm.Formatter, dst);

        [MethodImpl(Inline), Op]
        public IAsmFormatter Formatter()
            => new AsmFormatter(Asm.FormatConfig);

        [MethodImpl(Inline), Op]
        public IAsmFormatter Formatter(in AsmFormatConfig config)
            => new AsmFormatter(config);

        public AsmSemanticRender SemanticRender()
            => new AsmSemanticRender(Wf);

        [MethodImpl(Inline), Op]
        public IAsmWriter AsmWriter(FS.FilePath dst)
            => new AsmWriter(dst, Formatter());

        [MethodImpl(Inline), Op]
        public IAsmWriter AsmWriter(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, formatter(config));

        public IAsmImmWriter ImmWriter(ApiHostUri host)
            => ImmWriter(host, Wf.Db().ImmRoot());

        public IAsmDataEmitter DataEmitter()
            => AsmDataEmitter.create(Wf);

        [MethodImpl(Inline), Op]
        public ICaptureAlt CaptureAlt()
            => Capture.alt(Wf, Asm);
    }
}