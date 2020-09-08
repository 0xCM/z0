//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Konst;
    using static BufferSeqId;

    public class AsmChecks : IAsmTester
    {
        public IAsmContext Context {get;}

        public BufferTokens Tokens {get;}

        readonly BufferAllocation BufferAlloc;

        public ICaptureExchange CaptureExchange {get;}

        public AsmChecks(IAsmContext context)
        {
            Context = context;
            Tokens = Z0.Buffers.sequence(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();
            CaptureExchange = CaptureExchangeProxy.create(Context.CaptureCore, Tokens[Aux3]);
        }

        public void Dispose()
        {
            BufferAlloc.Dispose();
        }

        public ref readonly BufferToken this[BufferSeqId index]
            => ref Tokens[index];
    }
}