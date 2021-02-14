//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    readonly struct CaptureServices : ICaptureServices
    {
        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        [MethodImpl(Inline)]
        public CaptureServices(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        public IImmSpecializer ImmSpecializer()
            => new ImmSpecializer(Wf, Asm);

        public IAsmDecoder RoutineDecoder(in AsmFormatConfig? format)
            => AsmServices.decoder(format ?? AsmFormatConfig.Default);

        public ICaptureCore CaptureCore
            => Capture.core(Wf,Asm);
    }
}