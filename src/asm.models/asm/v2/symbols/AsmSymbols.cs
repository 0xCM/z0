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

    [ApiDataType]
    public readonly partial struct AsmSymbols
    {
        readonly Symbolic<Mnemonic,ushort> _Mnemonics;

        readonly AsmOpCodeDataset _OpCodes;

        [MethodImpl(Inline)]
        internal AsmSymbols(Symbolic<Mnemonic,ushort> mnemonics, AsmOpCodeDataset opcodes)
        {
            _Mnemonics = mnemonics;
            _OpCodes = opcodes;
        }

        public Symbols<Mnemonic,ushort> Mnemonics
        {
            [MethodImpl(Inline)]
            get => _Mnemonics.Symbols;
        }
    }

    partial struct asm
    {
        [Op]
        public static AsmSymbols symbols()
        {
            var mnemonics = Symbolic.cover<Mnemonic,ushort>();
            var opcodes = AsmOpCodes.dataset();
            return new AsmSymbols(mnemonics, opcodes);
        }
    }
}