//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public class AsmSigSymbols
    {
        public static AsmSigSymbols load()
            => new AsmSigSymbols();

        readonly Symbols<Mode> _Modes;

        readonly Symbols<EFlag> _EFlags;

        internal AsmSigSymbols()
        {
            _EFlags = Symbols.cache<EFlag>();
            _Modes = Symbols.cache<Mode>();
        }

        public Symbols<Mode> Modes
            => _Modes;

        public Symbols<EFlag> Flags
            => _EFlags;

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