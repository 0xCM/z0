//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmLang
    {
        [MethodImpl(Inline), Op]
        public static AsmCall call(string id, MemoryAddress src, Address16 callsite, MemoryAddress dst, string actualId, MemoryAddress actual = default)
            => new AsmCall(asm.client(id, src), callsite, asm.target(dst), asm.target(actualId, actual));

        [MethodImpl(Inline), Op]
        public static AsmCall call(MemoryAddress src, Address16 callsite, MemoryAddress dst, MemoryAddress actual = default)
            => new AsmCall(asm.client(src), callsite, asm.target(dst), asm.target(actual));
    }
}