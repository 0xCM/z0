//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface TCaptureServices : TAsmCore, ICaptureServices
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

        IImmEmissionWorkflow ImmEmissionWorkflow(IMultiSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, PartWfConfig config, CorrelationToken? ct = null)        
            => new ImmEmissionWorkflow(Context, sink, formatter, decoder, api, config.Target.ArchiveRoot, ct);
    }
}