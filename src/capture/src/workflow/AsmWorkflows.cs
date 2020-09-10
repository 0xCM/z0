//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    [ApiHost]
    public readonly struct AsmWorkflows
    {
        [MethodImpl(Inline), Op]
        public static IAsmContext asm(IAppContext root)
            => new AsmContext(root);

        [MethodImpl(Inline), Op]
        public static AsmWf create(IWfShell shell, IAsmContext asm)
            => new AsmWf(shell,asm);

        /// <summary>
        /// Creates a memory capture service
        /// </summary>
        /// <param name="buffer">The buffer size to allocate</param>
        [MethodImpl(Inline), Op]
        public static CaptureMemory memory(IWfShell wf, IAsmContext asm, ByteSize buffer)
            => new CaptureMemory(wf, asm, buffer);

        [MethodImpl(Inline), Op]
        public static IWfCaptureBroker capture(IWfShell wf)
            => new WfCaptureBroker(wf);

        [MethodImpl(Inline), Op]
        public static WfCaptureState state(IWfShell wf, IAsmContext asm)
            => new WfCaptureState(wf, asm);
    }
}