//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static AsmExpr;
    using static AsmCatalogSymbols.EFlag;
    using static AsmCatalogSymbols.Mode;
    using static Part;

    [ApiHost]
    public class AsmCatalogSymbols
    {
        readonly SymbolTable<Mode> _Modes;

        readonly SymbolTable<EFlag> _EFlags;

        public static AsmCatalogSymbols create()
            => new AsmCatalogSymbols();

        internal AsmCatalogSymbols()
        {
            _EFlags = SymbolStores.table<EFlag>();
            _Modes = SymbolStores.table<Mode>();
        }

        public ReadOnlySpan<Token<Mode>> Modes
            => _Modes.Tokens;

        public ReadOnlySpan<Token<EFlag>> Flags
            => _EFlags.Tokens;

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

        [Op]
        static Name symbolize(EFlag src)
            => src switch {
                OF => "E.OF",
                SF => "E.SF",
                ZF => "E.ZF",
                AF => "E.AF",
                CF => "E.CF",
                PF => "E.PF",
                _ => EmptyString
            };

       [Op]
        static Name symbolize(Mode src)
            => src switch {
                Valid => "V",
                Invalid => "I",
                NE => "NE",
                _ => EmptyString
            };
    }
}