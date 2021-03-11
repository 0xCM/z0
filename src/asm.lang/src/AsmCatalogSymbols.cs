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
            _EFlags = SymbolTables.create<EFlag>(symbolize);
            _Modes = SymbolTables.create<Mode>(symbolize);
        }


        public ReadOnlySpan<Token<Mode>> Modes
            => _Modes.Tokens;

        public ReadOnlySpan<Token<EFlag>> Flags
            => _EFlags.Tokens;

        public enum Mode : byte
        {
            None,

            Valid,

            Invalid,

            NE,
        }

        public enum EFlag : byte
        {
            None,

            OF,

            SF,

            ZF,

            AF,

            CF,

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