//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm;

    public readonly struct QuickCapture : IDisposable
    {
        readonly IAsmContext Context;

        readonly BufferAllocation Buffer;

        readonly BufferTokens Tokens;

        readonly ICaptureServiceProxy Service;

        public static QuickCapture create(IAsmContext asm)
        {
            var tokens = Buffers.sequence(asm.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = CaptureExchangeProxy.create(asm.CaptureCore, tokens[BufferSeqId.Aux3]);
            var service = CaptureServiceProxy.create(asm.CaptureCore, exchange);
            return new QuickCapture(asm, buffer, tokens, service);
        }

        [MethodImpl(Inline)]
        internal QuickCapture(IAsmContext context, BufferAllocation buffer, BufferTokens tokens, ICaptureServiceProxy capture)
        {
            Context = context;
            Tokens = tokens;
            Service = capture;
            Buffer =  buffer;
        }

        [MethodImpl(Inline)]
        public Option<ApiCapture> Capture(MethodInfo src)
            => Service.Capture(z.insist(src).Identify(), src);

        [MethodImpl(Inline)]
        public Option<CapturedMember> Capture(ApiMember src)
            => Service.Capture(src);

        [MethodImpl(Inline)]
        public Option<ApiCapture> Capture(ApiHostUri hos, MethodInfo src)
            => Service.Capture(z.insist(src).Identify(),src);

        public void Dispose()
        {
            Buffer.Dispose();
        }
    }
}