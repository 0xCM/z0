//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface TCaptureServices : IAsmCore, ICaptureServices
    {
        IAsmContext Context {get;}

        CaptureExchange CaptureExchange
            => Asm.CaptureExchange.create(Context);

        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmDecoder decoder)
            => new ImmSpecializer(decoder);

        IAsmDecoder ICaptureServices.RoutineDecoder(in AsmFormatSpec? format)
            => new AsmRoutineDecoder(format ?? AsmFormatSpec.Default);

        IImmEmitter ImmEmitter(IMultiSink sink, IApiSet api, IAsmFormatter formatter, IAsmDecoder decoder, WfConfig config, CorrelationToken? ct = null)
            => new EmitImmSpecials(Context, config, sink, formatter, decoder, api, config.TargetArchive.Root, ct);
    }
}