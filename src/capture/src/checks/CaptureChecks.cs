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

    public readonly struct CaptureChecks : ICaptureChecks
    {
        public static ICaptureChecks create(IWfRuntime wf)
            => new CaptureChecks(Capture.context(wf));

        public IAsmContext Context {get;}

        readonly NativeBuffer BufferAlloc;

        public BufferTokens Tokens {get;}

        public ICaptureExchange CaptureExchange {get;}

        [MethodImpl(Inline)]
        public CaptureChecks(IAsmContext context)
        {
            Context = context;
            Tokens = memory.alloc(Pow2.T16, 5, out BufferAlloc).Tokenize();
            CaptureExchange = Capture.exchange(Tokens[Aux3]);
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