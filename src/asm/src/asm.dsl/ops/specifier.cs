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
        public static AsmSpecifier specifier(in asci32 opcode, in asci64 sig)
            => new AsmSpecifier(opcode, sig);

        [MethodImpl(Inline), Op]
        public static AsmSpecifier specifier(in AsmOpCode opcode, in AsmSig sig)
            => new AsmSpecifier(opcode, sig);
    }
}