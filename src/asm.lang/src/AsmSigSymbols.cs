//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [ApiHost]
    public class AsmSigSymbols
    {
        public static AsmSigSymbols load()
            => new AsmSigSymbols();

        readonly SymbolTable<Mode> _Modes;

        readonly SymbolTable<EFlag> _EFlags;

        readonly SymbolTable<AsmMnemonicCode> _Mnemonics;

        readonly SymbolTable<AsmSigOpKind> _SigOps;

        readonly SymbolTable<AsmSigCompositeKind> _Composites;

        internal AsmSigSymbols()
        {
            _EFlags = SymbolStores.table<EFlag>();
            _Modes = SymbolStores.table<Mode>();
            _Mnemonics = SymbolStores.table<AsmMnemonicCode>();
            _SigOps = SymbolStores.table<AsmSigOpKind>();
            _Composites = SymbolStores.table<AsmSigCompositeKind>();
        }

        public SymbolTable<Mode> Modes
            => _Modes;

        public SymbolTable<EFlag> Flags
            => _EFlags;

        public SymbolTable<AsmSigOpKind> SigOps
            => _SigOps;

        public SymbolTable<AsmMnemonicCode> Mnemonics
            => _Mnemonics;

        public SymbolTable<AsmSigCompositeKind> Composites
            => _Composites;

        public enum Mode : byte
        {
            [Symbol("V")]
            Valid,

            [Symbol("I")]
            Invalid,

            [Symbol("NE")]
            NE,
        }

        public enum EFlag : byte
        {
            [Symbol("E.OF")]
            OF,

            [Symbol("E.SF")]
            SF,

            [Symbol("E.ZF")]
            ZF,

            [Symbol("E.AF")]
            AF,

            [Symbol("E.CF")]
            CF,

            [Symbol("E.PF")]
            PF,
        }
    }
}