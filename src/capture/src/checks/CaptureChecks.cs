//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CaptureChecks : ICaptureChecks
    {
        public static ICaptureChecks create(IWfRuntime wf)
            => new CaptureChecks(wf);

        public IAsmContext Context {get;}

        readonly NativeBuffer BufferAlloc;

        public BufferTokens Tokens {get;}

        [MethodImpl(Inline)]
        public CaptureChecks(IWfRuntime wf)
        {
            Context = new AsmContext(Apps.context(wf), wf);
            Tokens = memory.alloc(Pow2.T16, 5, out BufferAlloc).Tokenize();
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