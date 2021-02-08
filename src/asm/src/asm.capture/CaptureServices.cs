//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CaptureServices : ICaptureServices
    {
        public static ICaptureServices Service => default(CaptureServices);

        public IImmSpecializer ImmSpecializer(IAsmDecoder decoder)
            => new ImmSpecializer(decoder);

        public IAsmDecoder RoutineDecoder(in AsmFormatConfig? format)
            => AsmServices.decoder(format ?? AsmFormatConfig.Default);

        public ICaptureCore CaptureCore
            => Asm.CaptureCore.Service;
    }
}