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

        [MethodImpl(Inline)]
        public CaptureServices(IWfRuntime wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
        }

        public IAsmDecoder RoutineDecoder(in AsmFormatConfig? format)
            => Wf.AsmDecoder();

        public ICaptureCore CaptureCore
            => Wf.CaptureCore(Asm);
    }
}