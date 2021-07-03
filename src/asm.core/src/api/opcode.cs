//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpr opcode(string src)
            => new AsmOpCodeExpr(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AsmOpCode<T> opcode<T>(uint @base, T kind)
            where T : unmanaged, Enum
                => new AsmOpCode<T>(@base,kind);
    }
}