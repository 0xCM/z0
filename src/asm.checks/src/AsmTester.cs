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

    public interface IAsmTester : IService<IAsmContext>, IBufferedChecker, ITestDynamic, ICheckVectors, ICheckCapture 
    {        
        IAsmFunctionDecoder Decoder => Context.Decoder; 

        IAsmFormatter Formatter => Context.Formatter;

        IOperational Operational => Z0.Operational.Service;

        IArchives Archives => Z0.Archives.Services;

        IPolyrand IPolyrandProvider.Random  => Context.Random;

        ICaptureService ICaptureServiceProxy.CaptureService => Context.CaptureService;        

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(PartId part)
            => Archives.CaptureArchive(
                (Env.Current.LogDir + FolderName.Define("apps")) + FolderName.Define(part.Format()), 
                FolderName.Define("capture"));

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => Archives.CaptureArchive(root,area, subject);

        [MethodImpl(Inline)]
        FilePath AsmFilePath<T>(PartId part) => CaptureArchive(part).AsmPath<T>();

        [MethodImpl(Inline)]
        FilePath HexFilePath<T>(PartId part) => CaptureArchive(part).HexPath<T>();

        [MethodImpl(Inline)]
        IHostBitsArchive HostBits(PartId part, ApiHostUri host, FolderPath root = null)
            => Archives.HostBits(part, host, root);

        [MethodImpl(Inline)]
        IHostBitsArchive HostBits(PartId part, FolderPath root = null)
            => Archives.HostBits(part, root);

        [MethodImpl(Inline)]
        OperationCode ReadHostAsm(PartId part, ApiHostUri host, OpIdentity id)
            => Operational.ToApiCode(HostBits(part,host).Read(id).Single());

        void WriteAsm(MemberCapture capture, StreamWriter dst)
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
        [MethodImpl(Inline)]
        public static IAsmTester Create(IAsmContext context)
            => new AsmTester(context);

        [MethodImpl(Inline)]
        AsmTester(IAsmContext context)
        {
            Context = context;
            Buffers = BufferSeq.alloc(context.DefaultBufferLength, 5, out BufferAlloc).Tokenize();  
            CaptureExchange = CaptureExchangeProxy.Create(Context.CaptureService, Buffers[(int)Aux3], Buffers[(int)Aux4]);
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