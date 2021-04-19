//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public sealed class AsmServices
    {
        [Op]
        public static IAsmContext context(IWfRuntime wf)
            => new AsmContext(Apps.context(wf), wf);

        [MethodImpl(Inline), Op]
        public static IAsmRoutineFormatter formatter()
            => new AsmRoutineFormatter();

        [MethodImpl(Inline), Op]
        public static ICaptureExchange exchange(BufferToken capture)
            => new CaptureExchangeProxy(capture);

    }
}