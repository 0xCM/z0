//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class AsmServices : IAsmServices
    {
        [MethodImpl(Inline)]
        public static ICaptureExchange exchange(ICaptureCore service, BufferToken capture)
            => new CaptureExchangeProxy(service, capture);

        [MethodImpl(Inline)]
        public static ICaptureServiceProxy capture(ICaptureCore service, ICaptureExchange exchange)
            => new CaptureServiceProxy(service, exchange);

        public static QuickCapture quick(IAsmContext asm)
        {
            var tokens = Buffers.sequence(asm.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = AsmServices.exchange(asm.CaptureCore, tokens[BufferSeqId.Aux3]);
            var service = AsmServices.capture(asm.CaptureCore, exchange);
            return new QuickCapture(asm, buffer, tokens, service);
        }

        public static AsmServices init(IWfShell wf, IAsmContext asm)
            => new AsmServices(wf, asm);

        IWfShell Wf {get;}

        IAsmContext Asm {get;}

        [MethodImpl(Inline)]
        AsmServices(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        [MethodImpl(Inline), Op]
        public IAsmDecoder Decoder()
            => new AsmRoutineDecoder(Asm.FormatConfig);

        [MethodImpl(Inline), Op]
        public IAsmImmWriter ImmWriter(ApiHostUri host, FS.FolderPath dst)
            => new AsmImmWriter(host, Asm.Formatter, dst);

        [MethodImpl(Inline), Op]
        public AsmSemanticRender SemanticRender()
            => new AsmSemanticRender(Wf);

        [Op]
        public IAsmImmWriter ImmWriter(ApiHostUri host)
            => ImmWriter(host, Wf.Db().ImmRoot());

        [MethodImpl(Inline), Op]
        public static IAsmDecoder Decoder(in AsmFormatConfig config)
            => new AsmRoutineDecoder(config);
    }
}