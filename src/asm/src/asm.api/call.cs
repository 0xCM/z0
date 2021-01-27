//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmCallInfo call(string id, MemoryAddress src, Address16 callsite, MemoryAddress dst, string actualId, MemoryAddress actual = default)
            => new AsmCallInfo(client(id, src), callsite, target(dst), target(actualId, actual));

        [MethodImpl(Inline), Op]
        public static AsmCallInfo call(MemoryAddress src, Address16 callsite, MemoryAddress dst, MemoryAddress actual = default)
            => new AsmCallInfo(client(src), callsite, target(dst), target(actual));
    }
}