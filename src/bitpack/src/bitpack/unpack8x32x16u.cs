//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static cpu;

    partial struct BitPack
    {
        /// <summary>
        /// Projects 32 8-bit integers partitioned from a 256-bit source onto 32 16-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<ushort> unpack8x32x16u(in Cell256 src)
        {
            var storage = recover<ushort>(MemBlocks.block(n64).Bytes);
            cpu.vstore(vinflatelo256x16u(src), ref seek(storage,0));
            cpu.vstore(vinflatehi256x16u(src), ref seek(storage,16));
            return storage;
        }
    }
}