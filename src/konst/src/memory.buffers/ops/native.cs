//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Buffers
    {
        /// <summary>
        /// Allocates a native buffer
        /// </summary>
        /// <param name="length">The buffer length in bytes</param>
        [MethodImpl(Inline), Op]
        public static NativeBuffer native(uint length)
            => new NativeBuffer((memory.liberate(Marshal.AllocHGlobal((int)length), (int)length), length));
    }
}