//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static RegIndex;

    partial struct AsmTokens
    {
        /// <summary>
        /// Specifies the Mask registers
        /// </summary>
        [SymbolSource]
        public enum KReg : byte
        {
            [Symbol("k0")]
            K0 = r0,

            [Symbol("k1")]
            K1 = r1,

            [Symbol("k2")]
            K2 = r2,

            [Symbol("k3")]
            K3 = r3,

            [Symbol("k4")]
            K4 = r4,

            [Symbol("k5")]
            K5 = r5,

            [Symbol("k6")]
            K6 = r6,

            [Symbol("k7")]
            K7 = r7,
        }
    }
}