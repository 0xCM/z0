//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Linq;
    
    using static Konst;
    using static BufferSeqId;
    
    public readonly struct AsmTester : TAsmTester
    {
        public IAsmContext Context {get;}

        readonly BufferAllocation BufferAlloc;

        public BufferTokens Buffers {get;}

        public ICaptureExchange CaptureExchange {get;}

        [MethodImpl(Inline)]
        internal AsmTester(IAsmContext context)
        {
            Context = context;
            Buffers = Z0.Buffers.sequence(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();  
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureCore, Buffers[Aux3]);
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