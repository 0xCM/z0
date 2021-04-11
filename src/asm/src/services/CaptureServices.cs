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

        readonly IAsmContext Asm;

        readonly IAsmDecoder Decoder;

        [MethodImpl(Inline)]
        public CaptureServices(IWfRuntime wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            Decoder = wf.AsmDecoder();
        }

        public IAsmDecoder RoutineDecoder()
            => Decoder;

        public ICaptureCore CaptureCore
            => Wf.CaptureCore(Asm);
    }
}