//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmMem
    {
        public enum AddressWidth : byte
        {
            None = 0,

            /// <summary>
            /// Specifies 16-bit addressing
            /// </summary>
            [Symbol("16b")]
            w16 = 16,

            /// <summary>
            /// Specifies 32-bit addressing
            /// </summary>
            [Symbol("32b")]
            w32 = 32,

            /// <summary>
            /// Specifies 64-bit addressing
            /// </summary>
            [Symbol("64b")]
            w64 = 64,
        }
    }
}