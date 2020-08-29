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
    using static z;

    partial struct asm
    {
        [Op]
        public static AsmSymbols symbols()
        {
            var mnemonics = Symbolic.cover<Mnemonic,ushort>();
            var opcodes = AsmOpCodes.dataset();
            var registers = Symbolic.cover<RegisterKind,uint>();
            return new AsmSymbols(mnemonics, registers, opcodes);
        }
    }
}