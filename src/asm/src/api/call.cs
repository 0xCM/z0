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

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmCall call(string id, MemoryAddress src, ushort callsite, MemoryAddress dst, string actualId, MemoryAddress actual = default)
            => new AsmCall(client(id, src), callsite, target(dst), target(actualId, actual));

        [MethodImpl(Inline), Op]
        public static AsmCall call(MemoryAddress src, ushort callsite, MemoryAddress dst, MemoryAddress actual = default)
            => new AsmCall(client(src), callsite, target(dst), target(actual));
    }
}