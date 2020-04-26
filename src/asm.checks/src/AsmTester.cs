//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static BufferSeqId;

    public interface IAsmTester : IService<IAsmContext>, IBufferedChecker, ITestDynamic, ICheckVectors, ICheckCapture 
    {        
        IAsmFunctionDecoder Decoder => Context.Decoder; 

        IPolyrand IPolyrandProvider.Random  => Context.Random;

        ICaptureService ICaptureServiceProxy.CaptureService => Context.CaptureService;        
    }
    
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
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureControl, Buffers[(int)Aux3], Buffers[(int)Aux4]);
        }
        
        public IAsmContext Context {get;}

        readonly BufferAllocation BufferAlloc;

        public IBufferToken[] Buffers {get;}

        public ICaptureExchange CaptureExchange {get;}
        
        public IBufferToken this[BufferSeqId id]
        {
            [MethodImpl(Inline)]
            get => Buffers[(int)id];
        }

        public void Dispose()
        {
            BufferAlloc.Dispose();
        }
    }    
}