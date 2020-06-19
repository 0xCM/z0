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
    
    public readonly struct AsmTester : IAsmTester
    {
        public IAsmContext Context {get;}

        readonly BufferAllocation BufferAlloc;

        public BufferTokens Buffers {get;}

        public ICaptureExchange CaptureExchange {get;}

        [MethodImpl(Inline)]
        public static IAsmTester Create(IAsmContext context)
            => new AsmTester(context);

        [MethodImpl(Inline)]
        internal AsmTester(IAsmContext context)
        {
            Context = context;
            Buffers = BufferSeq.alloc(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();  
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureCore, Buffers[Aux3], Buffers[Aux4]);
        }
               
        public IBufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Buffers[id];
        }
        
        public void Dispose()
        {
            BufferAlloc.Dispose();
        }
    }    
}