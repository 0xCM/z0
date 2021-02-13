//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BufferSeqId;

    public readonly struct AsmTester : IAsmChecker
    {
        public IAsmContext Context {get;}

        readonly NativeBuffer BufferAlloc;

        public BufferTokens Tokens {get;}

        public ICaptureExchange CaptureExchange {get;}

        [MethodImpl(Inline)]
        public AsmTester(IAsmContext context)
        {
            Context = context;
            Tokens = Z0.Buffers.sequence(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = AsmServices.exchange(Context.CaptureCore, Tokens[Aux3]);
        }

        public ref readonly BufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => ref Tokens[id];
        }

        public void Dispose()
        {
            BufferAlloc.Dispose();
        }
    }
}