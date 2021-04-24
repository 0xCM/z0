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
        readonly IWfRuntime Wf;

        readonly IAsmDecoder Decoder;

        readonly ICaptureCore Capture;

        readonly IAsmRoutineFormatter Formatter;

        [MethodImpl(Inline)]
        public CaptureServices(IWfRuntime wf)
        {
            Wf = wf;
            Decoder = Wf.AsmDecoder();
            Capture = Wf.CaptureCore();
            Formatter = new AsmFormatter();
        }

        public IAsmRoutineFormatter RoutineFormatter
            => Formatter;

        public IAsmDecoder RoutineDecoder
            => Decoder;

        public ICaptureCore CaptureCore
            => Capture;
    }
}