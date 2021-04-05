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
        public static IAsmContext context(IWfShell wf)
            => new AsmContext(Apps.context(wf), wf);

        [Op]
        public static IApiHostCapture HostCapture(IWfShell wf)
            => ApiHostCapture.create(wf);

        [MethodImpl(Inline), Op]
        public static IAsmRoutineFormatter formatter()
            => new AsmRoutineFormatter(null);

        [MethodImpl(Inline), Op]
        public static ICaptureExchange exchange(BufferToken capture)
            => new CaptureExchangeProxy(capture);

        public static IAsmImmWriter immwriter(IWfShell wf, IAsmContext context, ApiHostUri host)
            => new AsmImmWriter(wf, host, wf.AsmFormatter());
    }
}