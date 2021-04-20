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
        /// Classifies the accessible debug registers
        /// </summary>
        [SymbolSource]
        public enum DebugReg : uint
        {
            [Symbol("dr0")]
            DR0 = r0,

            [Symbol("dr1")]
            DR1 = r1,

            [Symbol("dr2")]
            DR2 = r2,

            [Symbol("dr3")]
            DR3 = r3,

            [Symbol("dr6")]
            DR6 = r6,

            [Symbol("dr7")]
            DR7 = r7,
        }
    }
}