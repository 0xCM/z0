//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmX
    {
        /// <summary>
        /// Specifies the MMX registers
        /// </summary>
        [SymbolSource]
        public enum MmxReg : byte
        {
            [Symbol("mmx0")]
            MM0 = r0,

            [Symbol("mmx1")]
            MM1 = r1,

            [Symbol("mmx2")]
            MM2 = r2,

            [Symbol("mmx3")]
            MM3 = r3,

            [Symbol("mmx4")]
            MM4 = r4,

            [Symbol("mmx5")]
            MM5 = r5,

            [Symbol("mmx6")]
            MM6 = r6,

            [Symbol("mmx7")]
            MM7 = r7,
        }
    }
}