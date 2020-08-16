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

        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmRoutineDecoder decoder)
            => new ImmSpecializer(decoder);        

        IAsmRoutineDecoder ICaptureServices.RoutineDecoder(in AsmFormatSpec? format)
            => new AsmRoutineDecoder(format ?? AsmFormatSpec.Default);

        IImmEmitter ImmEmissionWorkflow(IMultiSink sink, IApiSet api, IAsmFormatter formatter, IAsmRoutineDecoder decoder, WfConfig config, CorrelationToken? ct = null)        
            => new EmitImmSpecials(Context, sink, formatter, decoder, api, config.Target.ArchiveRoot, ct);
    }
}