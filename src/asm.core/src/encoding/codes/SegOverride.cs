//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        /// <summary>
        /// The segment override codes as specified by Intel Vol II, 2.1.1
        /// </summary>
        public enum SegOverride : byte
        {
            None = 0,

            [Symbol("cs", "CS segment override")]
            CS = x2e,

            [Symbol("ss", "SS segment override")]
            SS = x36,

            [Symbol("ds","DS segment override")]
            DS = x3e,

            [Symbol("es", "ES segment override")]
            ES = x26,

            [Symbol("fs", "FS segment override")]
            FS = x64,

            [Symbol("gs", "GS segment override")]
            GS = x65,
        }
    }
}