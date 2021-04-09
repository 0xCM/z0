//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmLang
    {
        [SymbolSource]
        public enum SegToken : byte
        {
            [Symbol("cs", "CS segment override")]
            CS,

            [Symbol("ss", "SS segment override")]
            SS,

            [Symbol("ds", "DS segment override")]
            DS,

            [Symbol("es", "ES segment override")]
            ES,

            [Symbol("fs", "FS segment override")]
            FS,

            [Symbol("gs", "GS segment override")]
            GS,
        }
    }
}