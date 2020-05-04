//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
   
    using static Seed;

    using Svc = Z0;
    
    public readonly struct AsmWorkflows : IAsmWorkflows
    {
        public IAsmContext Context {get;}

        [MethodImpl(Inline)]
        public static IAsmWorkflows Create(IAsmContext context) 
            => new AsmWorkflows(context);

        [MethodImpl(Inline)]
        internal AsmWorkflows(IAsmContext context) 
            => Context = context;
    }
    
    public interface IAsmWorkflows : IAsmContextual
    {
        CaptureExchange CaptureExchange
            => Asm.CaptureExchange.Create(Context);        

        /// <summary>
        /// Creates a default capture worklfow
        /// </summary>
        /// <param name="archive">The archive to target</param>
        [MethodImpl(Inline)]
        ICaptureWorkflow CaptureWorkflow(ICaptureArchive archive)
            => new CaptureWorkflow(Context, AsmDecoder(), AsmFormatter(), Capture.Services.AsmWriterFactory, archive);

        /// <summary>
        /// Creates a capture workflow predicated on caller-supplied services
        /// </summary>
        /// <param name="decoder">The decoder to use</param>
        /// <param name="formatter">The formatter to use</param>
        /// <param name="archive">The archive to target</param>
        [MethodImpl(Inline)]
        ICaptureWorkflow CaptureWorkflow(IAsmFunctionDecoder decoder, IAsmFormatter formatter, ICaptureArchive archive)
            => new CaptureWorkflow(Context, decoder, formatter, Capture.Services.AsmWriterFactory, archive);

        /// <summary>
        /// Creates an imm emission workflow using default decoding and formatting servcies
        /// </summary>
        /// <param name="sink"></param>
        /// <param name="api"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        IImmEmissionWorkflow ImmEmissionWorkflow(IAppMsgSink sink, IApiSet api, FolderPath dst)        
            => new ImmEmissionWorkflow(Context, sink, AsmFormatter(), AsmDecoder(), api, dst);

        [MethodImpl(Inline)]
        IImmEmissionWorkflow ImmEmissionWorkflow(IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(Context, sink, formatter, decoder, api, dst);

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
        IMemberExtractor ICaptureServices.HostExtractor(int? bufferlen)
            => MemberExtractor.Create(bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        IHostCaptureService IAsmContextual.HostCaptureService(FolderPath root)
            => new HostCaptureService(Context, root);
    }
}