//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface TAsmWorkflows : TAsmCore, ICaptureServices
    {
        IAsmContext Context {get;}        
        
        ICaptureCore ICaptureServices.CaptureCore 
            => new CaptureCore();
        
        CaptureExchange CaptureExchange
            => Asm.CaptureExchange.Create(Context);        

        IAsmFunctionDecoder ICaptureServices.DefaultFunctionDecoder
            => AsmFunctionDecoder.Default;

        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmFunctionDecoder decoder)
            => new ImmSpecializer(decoder);        

        IAsmFunctionDecoder ICaptureServices.AsmDecoder(in AsmFormatSpec? format)
            => new AsmFunctionDecoder(format ?? AsmFormatSpec.Default);

        IMemberExtractor ICaptureServices.HostExtractor(int bufferlen)
            => MemberExtraction.service(bufferlen);

        /// <summary>
        /// Creates a default capture worklfow
        /// </summary>
        /// <param name="archive">The archive to target</param>
        ICaptureWorkflow CaptureWorkflow(TCaptureArchive archive)
            => new CaptureWorkflow(Context, AsmDecoder(), Formatter(), Capture.Services.AsmWriterFactory, archive);

        /// <summary>
        /// Creates a capture workflow predicated on caller-supplied services
        /// </summary>
        /// <param name="decoder">The decoder to use</param>
        /// <param name="formatter">The formatter to use</param>
        /// <param name="archive">The archive to target</param>
        ICaptureWorkflow CaptureWorkflow(IAsmFunctionDecoder decoder, IAsmFormatter formatter, TCaptureArchive archive)
            => new CaptureWorkflow(Context, decoder, formatter, Capture.Services.AsmWriterFactory, archive);

        /// <summary>
        /// Creates an imm emission workflow using default decoding and formatting servcies
        /// </summary>
        /// <param name="sink">The event message sink</param>
        /// <param name="api">The api set available to the workflow</param>
        /// <param name="dst">The emission output directory</param>
        IImmEmissionWorkflow ImmEmissionWorkflow(IAppMsgSink sink, IApiSet api, FolderPath dst)        
            => new ImmEmissionWorkflow(Context, sink, Formatter(), AsmDecoder(), api, dst);

        IImmEmissionWorkflow ImmEmissionWorkflow(IAppMsgSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, FolderPath dst)        
            => new ImmEmissionWorkflow(Context, sink, formatter, decoder, api, dst);
    }
}