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
        [MethodImpl(Inline), Op]
        public static AsmServices init(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        [MethodImpl(Inline), Op]
        public static IAsmDecoder decoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);

        [MethodImpl(Inline), Op]
        public static AsmWriter writer(FS.FilePath dst)
            => new AsmWriter(dst, new AsmFormatter());

        [MethodImpl(Inline), Op]
        public static AsmWriter writer(FS.FilePath dst, in AsmFormatConfig config)
            => new AsmWriter(dst, new AsmFormatter(config));

        [MethodImpl(Inline), Op]
        public static AsmWriter writer(FS.FilePath dst, IAsmFormatter formatter)
            => new AsmWriter(dst, formatter);

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