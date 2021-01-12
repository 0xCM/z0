//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface TCaptureServices : IAsmServices, ICaptureServices
    {
        IAsmContext Context {get;}

        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmDecoder decoder)
            => new ImmSpecializer(decoder);

        IAsmDecoder ICaptureServices.RoutineDecoder(in AsmFormatConfig? format)
            => asm.decoder(format ?? AsmFormatConfig.Default);
    }
}