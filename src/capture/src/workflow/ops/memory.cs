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

    partial struct WfBuilder
    {
        /// <summary>
        /// Creates a memory capture service
        /// </summary>
        /// <param name="buffer">The buffer size to allocate</param>
        [MethodImpl(Inline), Op]
        public static CaptureMemory memory(IAsmContext root, IWfContext wf, ByteSize buffer)
            => new CaptureMemory(root, wf, buffer);
    }
}