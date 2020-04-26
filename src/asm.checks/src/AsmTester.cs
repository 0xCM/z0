//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static BufferSeqId;

    public interface IAsmTester : IService<IAsmContext>, IBufferedChecker, ITestDynamic, ICheckVectors, ICheckCapture 
    {        
        IAsmFunctionDecoder Decoder => Context.Decoder; 

        IAsmFormatter Formatter => Context.Formatter;

        IPolyrand IPolyrandProvider.Random  => Context.Random;

        ICaptureService ICaptureServiceProxy.CaptureService => Context.CaptureService;        

        ICaptureArchive CaptureArchive => Context.RootCaptureArchive;        

        FilePath AsmFilePath<T>() => CaptureArchive.AsmPath<T>();

        FilePath HexFilePath<T>() => CaptureArchive.HexPath<T>();

        void WriteAsm(MemberCapture capture, StreamWriter dst)
        {
            var asm = Decoder.Decode(capture).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.WriteLine(formatted);            
        }
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