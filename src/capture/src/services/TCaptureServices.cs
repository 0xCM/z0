//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface TCaptureServices : TAsmCore, ICaptureServices
    {
        IAsmContext Context {get;}        
                
        CaptureExchange CaptureExchange
            => Asm.CaptureExchange.Create(Context);        

        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmFunctionDecoder decoder)
            => new ImmSpecializer(decoder);        

        IAsmFunctionDecoder ICaptureServices.FunctionDecoder(in AsmFormatSpec? format)
            => new AsmFunctionDecoder(format ?? AsmFormatSpec.Default);

        IImmEmissionWorkflow ImmEmissionWorkflow(IMultiSink sink, IApiSet api, IAsmFormatter formatter, IAsmFunctionDecoder decoder, WfConfig config, CorrelationToken? ct = null)        
            => new SpecializeImmediates(Context, sink, formatter, decoder, api, config.Target.ArchiveRoot, ct);
    }
}