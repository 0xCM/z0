//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial struct Buffers
    {
        [MethodImpl(Inline), Op]
        public static void write(BinaryCode src, ByteSize size, MemoryAddress dst)
            => src.Data.CopyTo(Address.edit2<byte>(dst, size));
    }
}