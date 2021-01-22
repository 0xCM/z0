//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface TCaptureServices : ICaptureServices
    {
        IImmSpecializer ICaptureServices.ImmSpecializer(IAsmDecoder decoder)
            => new ImmSpecializer(decoder);

        IAsmDecoder ICaptureServices.RoutineDecoder(in AsmFormatConfig? format)
            => AsmServices.Decoder(format ?? AsmFormatConfig.Default);
    }
}