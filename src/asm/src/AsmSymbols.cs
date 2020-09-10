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

        readonly Symbolic<RegisterKind,uint> _Registers;

        readonly AsmOpCodeDataset _OpCodes;

        [MethodImpl(Inline)]
        internal AsmSymbols(Symbolic<Mnemonic,ushort> mnemonics, Symbolic<RegisterKind,uint> registers, AsmOpCodeDataset opcodes)
        {
            _Mnemonics = mnemonics;
            _OpCodes = opcodes;
            _Registers = registers;
        }

        public SymbolSet<Mnemonic,ushort> Mnemonics
        {
            [MethodImpl(Inline)]
            get => _Mnemonics.Symbols;
        }

        public ReadOnlySpan<AsmOpCodeTable> OpCodes
        {
            [MethodImpl(Inline)]
            get => _OpCodes.Entries.View;
        }

        public SymbolSet<RegisterKind,uint> Registers
        {
            [MethodImpl(Inline)]
            get => _Registers.Symbols;
        }
    }
}