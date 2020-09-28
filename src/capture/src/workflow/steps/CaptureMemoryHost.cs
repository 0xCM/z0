//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;

    using static z;

    [Step]
    public sealed class CaptureMemoryHost : WfHost<CaptureMemoryHost>
    {
        IAsmContext Asm;

        MemoryAddress[] Sources;

        /// <summary>
        /// Creates a memory capture service
        /// </summary>
        /// <param name="buffer">The buffer size to allocate</param>
        public static CaptureMemoryHost create(IAsmContext asm, MemoryAddress[] addresses)
        {
            var host = new CaptureMemoryHost();
            host.Asm = asm;
            host.Sources = addresses;
            return host;
        }

        protected override void Execute(IWfShell wf)
        {
            using var step = new CaptureMemory(wf, this, Asm, Sources);
            step.Run();
        }
    }
}