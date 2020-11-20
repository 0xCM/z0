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

    [ApiType]
    public readonly partial struct AsmSymbols
    {
        readonly NamedSymbols<Mnemonic,ushort> _Mnemonics;

        readonly NamedSymbols<RegisterKind,uint> _Registers;

        readonly AsmOpCodeDataset _OpCodes;

        [MethodImpl(Inline)]
        public AsmSymbols(NamedSymbols<Mnemonic,ushort> mnemonics, NamedSymbols<RegisterKind,uint> registers, AsmOpCodeDataset opcodes)
        {
            _Mnemonics = mnemonics;
            _OpCodes = opcodes;
            _Registers = registers;
        }

        public SymbolStore<Mnemonic,ushort> Mnemonics
        {
            [MethodImpl(Inline)]
            get => _Mnemonics.Symbols;
        }

        public ReadOnlySpan<AsmOpCodeRow> OpCodes
        {
            [MethodImpl(Inline)]
            get => _OpCodes.Entries.View;
        }

        public SymbolStore<RegisterKind,uint> Registers
        {
            [MethodImpl(Inline)]
            get => _Registers.Symbols;
        }
    }
}