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
        
        public static QuickCapture create(IAsmContext context)
        {            
            var tokens = Buffers.sequence(context.DefaultBufferLength, 5, out var buffer).Tokenize();
            var exchange = CaptureExchangeProxy.Create(context.CaptureCore, tokens[BufferSeqId.Aux3]);
            var service = CaptureServiceProxy.Create(context.CaptureCore, exchange);
            return new QuickCapture(context, buffer, tokens, service);
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
        public Option<CapturedCode> Capture(MethodInfo src)
        {
            var id = z.insist(src).Identify();
            return Service.Capture(id,src);
        }

        [MethodImpl(Inline)]
        public Option<CapturedCode> Capture(ApiHostUri hos, MethodInfo src)
        {
            var id = z.insist(src).Identify();
            return Service.Capture(id,src);
        }

        public void Dispose()
        {
            Buffer.Dispose();
        }
    }
}