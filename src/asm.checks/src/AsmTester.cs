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
    
    using static Seed;
    using static BufferSeqId;

    public interface IAsmTester : 
        IService<IAsmContext>, 
        IBufferedChecker, 
        ITestDynamic, 
        ICheckVectors, 
        ICheckCapture 
    {        
        IAsmFunctionDecoder Decoder 
            => Context.Decoder; 

        IAsmFormatter Formatter 
            => Context.Formatter;

        IUriBitsQuery UriBitQuery 
            => Z0.UriBitsQuery.Service;

        IArchives Archives 
            => Z0.Archives.Services;

        IPolyrand IPolyrandProvider.Random 
            => Context.Random;

        ICaptureService ICaptureServiceProxy.CaptureService 
            => Context.CaptureService;        

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(PartId part)
            => Archives.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root)
            => Archives.CaptureArchive(root, null, null);

        [MethodImpl(Inline)]
        FilePath AsmFilePath<T>(PartId part) 
            => CaptureArchive(part).AsmPath<T>();

        [MethodImpl(Inline)]
        FilePath HexFilePath<T>(PartId part) 
            => CaptureArchive(part).HexPath<T>();

        [MethodImpl(Inline)]
        IUriBitsArchive UriBitsArchive(FolderPath root)
            => Archives.UriBitsArchive(root);

        void WriteAsm(CapturedCode capture, StreamWriter dst)
        {
            var asm = Decoder.Decode(capture).Require();
            var formatted = Formatter.FormatFunction(asm);
            dst.WriteLine(formatted);            
        }

        void WriteAsm(AsmFunction f, StreamWriter dst)
            => dst.WriteLine(Formatter.FormatFunction(f));
    }
    
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
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureService, Buffers[Aux3], Buffers[Aux4]);
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