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

    using Svc = Z0;

    public readonly struct AsmWorkflows : IAsmWorkflows
    {
        public IAsmContext Context {get;}

        public static ICaptureServices Stateless => default(AsmWorkflows);

        [MethodImpl(Inline)]
        public static IAsmWorkflows Contextual(IAsmContext context) 
            => new AsmWorkflows(context);

        [MethodImpl(Inline)]
        internal AsmWorkflows(IAsmContext context) => Context = context;

        [MethodImpl(Inline)]
        IHostCaptureService HostCaptureService(FolderName area, FolderName subject)
            => new HostCaptureService(Context, area ?? FolderName.Empty, subject ?? FolderName.Empty);

    }
    
    public interface IAsmWorkflows : IAsmContextual
    {
        CaptureExchange CaptureExchange
            => Asm.CaptureExchange.Create(Context);        
            
        [MethodImpl(Inline)]
        IMemoryExtractor ICaptureServices.MemoryExtractor(byte[] buffer)
            => Svc.MemoryExtractor.Create(buffer);

        [MethodImpl(Inline)]
        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmFunctionDecoder decoder)
            => new ImmSpecializer(decoder);        

        [MethodImpl(Inline)]
        IAsmFunctionDecoder ICaptureServices.AsmDecoder(in AsmFormatSpec? format)
            => new AsmFunctionDecoder(format ?? AsmFormatSpec.Default);

        [MethodImpl(Inline)]
        ICaptureService ICaptureServices.CaptureService(IMultiDiviner diviner)
            => new CaptureService(diviner ?? Diviner);        

        [MethodImpl(Inline)]
        IHostCodeExtractor ICaptureServices.HostExtractor(int? bufferlen)
            => HostCodeExtractor.Create(bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        IHostCaptureService IAsmContextual.HostCaptureService(FolderPath root)
            => new HostCaptureService(Context, root);

        [MethodImpl(Inline)]
        IImmEmissionWorkflow ImmEmissionWorkflow(IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(Context, sink, formatter, decoder, api, dst);

        [MethodImpl(Inline)]
        ICaptureWorkflow CaptureWorkflow(IAsmFunctionDecoder decoder, IAsmFormatter formatter, ICaptureArchive archive)
            => new CaptureWorkflow(Context, decoder, formatter, AsmWorkflows.Stateless.AsmWriterFactory, archive);
    }
}