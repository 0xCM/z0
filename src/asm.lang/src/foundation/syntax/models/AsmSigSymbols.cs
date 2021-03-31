//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [ApiHost]
    public class AsmSigSymbols
    {
        public static AsmSigSymbols load()
            => new AsmSigSymbols();

        readonly SymTable<Mode> _Modes;

        readonly SymTable<EFlag> _EFlags;

        readonly SymTable<AsmMnemonicCode> _Mnemonics;

        readonly SymTable<AsmSigToken> _SigOps;

        readonly SymTable<CompositeSigToken> _Composites;

        internal AsmSigSymbols()
        {
            _EFlags = Symbols.table<EFlag>();
            _Modes = Symbols.table<Mode>();
            _Mnemonics = Symbols.table<AsmMnemonicCode>();
            _SigOps = Symbols.table<AsmSigToken>();
            _Composites = Symbols.table<CompositeSigToken>();
        }

        public SymTable<Mode> Modes
            => _Modes;

        public SymTable<EFlag> Flags
            => _EFlags;

        public SymTable<AsmSigToken> SigOps
            => _SigOps;

        public SymTable<AsmMnemonicCode> Mnemonics
            => _Mnemonics;

        public SymTable<CompositeSigToken> Composites
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