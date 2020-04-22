//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;
    using static BufferSeqId;

    public readonly struct AsmTester : IAsmTester
    {
        [MethodImpl(Inline)]
        public static IAsmTester Create(IAsmContext context)
            => new AsmTester(context);

        [MethodImpl(Inline)]
        AsmTester(IAsmContext context)
        {
            Context = context;
            Buffers = BufferSeq.alloc(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();            
        }
        
        public IAsmContext Context {get;}

        readonly BufferAllocation BufferAlloc;

        readonly IBufferToken[] Buffers;

        public IPolyrand Random => Context.Random;
        
        public void Dispose()
        {
            BufferAlloc.Dispose();
        }

        public IBufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Buffers[(int)id];
        }
    }    
}