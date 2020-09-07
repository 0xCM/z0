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

    partial struct AsmWfBuilder
    {
        /// <summary>
        /// Creates a memory capture service
        /// </summary>
        /// <param name="buffer">The buffer size to allocate</param>
        [MethodImpl(Inline), Op]
        public static CaptureMemory memory(IWfShell wf, IAsmContext asm, ByteSize buffer)
            => new CaptureMemory(wf, asm, buffer);
    }
}