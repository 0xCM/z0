//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BufferSeqId;

    public readonly struct AsmTester : TAsmTester
    {
        public IAsmContext Context {get;}

        readonly BufferAllocation BufferAlloc;

        public BufferTokens Buffers {get;}

        public ICaptureExchange CaptureExchange {get;}

        [MethodImpl(Inline)]
        public AsmTester(IAsmContext context)
        {
            Context = context;
            Buffers = Z0.Buffers.sequence(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = CaptureExchangeProxy.create(Context.CaptureCore, Buffers[Aux3]);
        }

        public ref readonly BufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => ref Buffers[id];
        }

        public void Dispose()
        {
            BufferAlloc.Dispose();
        }
    }
}