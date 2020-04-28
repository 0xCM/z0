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

        public static ICaptureServices Stateless => default(AsmWorkflows);

        [MethodImpl(Inline)]
        public static IAsmWorkflows Contextual(IAsmContext context) => new AsmWorkflows(context);

        [MethodImpl(Inline)]
        internal AsmWorkflows(IAsmContext context) => Context = context;
    }
    
    public interface IAsmWorkflows : IAsmContextual
    {
        [MethodImpl(Inline)]
        IMemoryCapture ICaptureServices.MemoryCapture(IAsmInstructionDecoder decoder, int bufferlen)
            => new MemoryCaptureService(decoder, bufferlen);    

        [MethodImpl(Inline)]
        IMemoryExtractor ICaptureServices.MemoryExtractor(byte[] buffer)
            => Svc.MemoryExtractor.Create(buffer);

        [MethodImpl(Inline)]
        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmFunctionDecoder decoder)
            => new ImmSpecializer(decoder);        

        /// <summary>
        /// Creates a function decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        IAsmFunctionDecoder ICaptureServices.FunctionDecoder(in AsmFormatSpec? format)
            => new AsmFunctionDecoder(format ?? AsmFormatSpec.Default);

        [MethodImpl(Inline)]
        IHostAsmArchiver ICaptureServices.ImmFunctionArchive(ApiHostUri host, IAsmFormatter formatter, FolderPath dst)
            => ImmArchive(host, formatter, dst);

        /// <summary>
        /// Creates a capture serivce predicated, or not, on an optionally-specified divination service
        /// </summary>
        /// <param name="diviner">A divination service, or not</param>
        [MethodImpl(Inline)]
        ICaptureService ICaptureServices.CaptureService(IMultiDiviner diviner)
            => new CaptureService(diviner ?? Diviner);        

        /// <summary>
        /// Creates an instruction decoder
        /// </summary>
        /// <param name="context">The source context</param>
        /// <param name="format">The format configuration</param>
        [MethodImpl(Inline)]
        IAsmInstructionDecoder ICaptureServices.InstructionDecoder(in AsmFormatSpec? format)
            => new AsmInstructionDecoder(format ?? AsmFormatSpec.Default);

        [MethodImpl(Inline)]
        IMemoryExtractParser ICaptureServices.MemoryExtractParser(byte[] buffer)
            => Svc.MemoryExtractParser.Create(buffer);

        /// <summary>
        /// Creates a code extractor with an optionally-specified buffer length
        /// </summary>
        /// <param name="bufferlen">The desired buffer length</param>
        [MethodImpl(Inline)]
        IHostCodeExtractor ICaptureServices.HostExtractor(int? bufferlen)
            => HostCodeExtractor.Create(bufferlen ?? Pow2.T14);

        [MethodImpl(Inline)]
        IHostCaptureService IAsmContextual.HostCaptureService(FolderName area, FolderName subject)
            => new HostCaptureService(Context, area ?? FolderName.Empty, subject ?? FolderName.Empty);

        [MethodImpl(Inline)]
        IHostCaptureService IAsmContextual.HostCaptureService(FolderPath root)
            => new HostCaptureService(Context, root);

        [MethodImpl(Inline)]
        IImmEmissionWorkflow ImmEmissionWorkflow(IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(Context, sink, formatter, decoder, api, dst);

        [MethodImpl(Inline)]
        IHostCaptureWorkflow HostCaptureWorkflow(IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory)
            => new HostCaptureWorkflow(Context, decoder, formatter, writerfactory);      

        CaptureExchange CaptureExchange
            => Asm.CaptureExchange.Create(Context);
    }
}