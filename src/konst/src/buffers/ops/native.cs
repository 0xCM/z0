//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline), Op]
        public static BufferAllocation native(uint length)
            => Buffers.own((liberate(Marshal.AllocHGlobal((int)length), (int)length), length));
    }
}